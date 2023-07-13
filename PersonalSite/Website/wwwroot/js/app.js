let btn = document.querySelector('.mouse-cursor-gradient');
btn.addEventListener('mousemove', e => {
    let rect = e.target.getBoundingClientRect();
    let x = e.clientX - rect.left;
    let y = e.clientY - rect.top;
    btn.style.setProperty('--mouse-x', x + 'px');
    btn.style.setProperty('--mouse-y', y + 'px');
});