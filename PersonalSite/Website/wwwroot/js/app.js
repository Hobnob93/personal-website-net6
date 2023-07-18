let div = document.querySelector('.mouse-cursor-gradient');
div.addEventListener('mousemove', e => {
    let x = e.clientX;
    let y = e.clientY;
    div.style.setProperty('--mouse-x', x + 'px');
    div.style.setProperty('--mouse-y', y + 'px');
});

function randomlySizeHeroColumns() {
    let heroColumns = document.querySelectorAll('.hero-column');
    heroColumns.forEach(column => {
        var topHeight = randomIntFromInterval(40, 60);
        var bottomHeight = 100 - topHeight;

        column.children[0].style.setProperty('--hero-tile-height', topHeight + 'vh');
        column.children[1].style.setProperty('--hero-tile-height', bottomHeight + 'vh');
    });
}

function randomIntFromInterval(min, max) { // min and max included 
    return Math.floor(Math.random() * (max - min + 1) + min)
}