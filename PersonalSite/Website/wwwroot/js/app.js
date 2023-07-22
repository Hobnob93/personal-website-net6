$(document).on('mousemove', function (e) {
    document.documentElement.style.setProperty('--mouse-x', e.pageX + 'px');
    document.documentElement.style.setProperty('--mouse-y', e.pageY + 'px');
});

function randomlySizeHeroTiles() {
    for (let i = 0; i < 4; i++) {
        var top = document.querySelector('.hero-tile.top.left-' + i);
        var bottom = document.querySelector('.hero-tile.bottom.left-' + i);

        var topHeight = randomIntFromInterval(40, 60);
        var bottomHeight = 100 - topHeight;

        top.style.setProperty('--hero-tile-height', topHeight + 'vh');
        bottom.style.setProperty('--hero-tile-height', bottomHeight + 'vh');
    }
}

function randomIntFromInterval(min, max) { // min and max included 
    return Math.floor(Math.random() * (max - min + 1) + min)
}

function initialiseHeroTileEvents() {
    $('.hero-tile').mouseenter(function () {
        let target = $(this);
        let topBottomClass = (target.hasClass('top') ? 'top' : 'bottom');

        $('.hero-tile.' + topBottomClass).each(function () {
            console.log('loop');
            let loopTarget = $(this);

            if (loopTarget.is(target) === false) {
                loopTarget.find('.hero-tile-text').addClass('hide');
            }
        });
    });

    $('.hero-tile').mouseleave(function () {
        let topBottomClass = ($(this).hasClass('top') ? 'top' : 'bottom');
        $('.hero-tile.' + topBottomClass).each(function () {
            $(this).find('.hero-tile-text').removeClass('hide');
        });
    });
}

function setupHeroTiles() {
    randomlySizeHeroTiles();
    initialiseHeroTileEvents();
}