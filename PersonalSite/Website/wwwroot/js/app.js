let btn = document.querySelector('.mouse-cursor-gradient');
btn.addEventListener('mousemove', e => {
    let x = e.clientX;
    let y = e.clientY;
    btn.style.setProperty('--mouse-x', x + 'px');
    btn.style.setProperty('--mouse-y', y + 'px');
});