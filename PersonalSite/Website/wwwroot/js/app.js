let div = document.querySelector('.mouse-cursor-gradient');
div.addEventListener('mousemove', e => {
    let x = e.clientX;
    let y = e.clientY;
    div.style.setProperty('--mouse-x', x + 'px');
    div.style.setProperty('--mouse-y', y + 'px');
});

function randomlySizeHeroColumns() {
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