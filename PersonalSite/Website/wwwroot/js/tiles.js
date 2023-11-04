function randomlySizeTiles() {
    for (let i = 1; i <= 4; i++) {
        var top = document.querySelector('.tile.first-word.letter-' + i);
        var bottom = document.querySelector('.tile.second-word.letter-' + i);

        var topHeight = randomIntFromInterval(41, 59);
        var bottomHeight = 100 - topHeight;

        top.style.setProperty('--tile-height', topHeight + 'vh');
        bottom.style.setProperty('--tile-height', bottomHeight + 'vh');
    }
}

function randomIntFromInterval(min, max) { // min and max included 
    return Math.floor(Math.random() * (max - min + 1) + min)
}

function initialiseTileEvents() {
    let hoverMediaQuery = window.matchMedia("(hover: hover)");

    if (hoverMediaQuery.matches) {
        setupHoverEvents();
    } else {
        setupTouchEvents();
    }
}

function blazor_tileClick() {
    let hoverMediaQuery = window.matchMedia("(hover: hover)");

    if (hoverMediaQuery.matches) {
        return true;
    }

    return false;
}

function setupTouchEvents() {
    $('.tile')
        .unbind()
        .click(function () {
            let target = $(this);

            $('.tile').each(function () {
                let loopTarget = $(this);
                if (loopTarget.is(target) === false) {
                    if (loopTarget.hasClass('active')) {
                        loopTarget.trigger('click');
                    }
                }
            });

            if (target.hasClass('active')) {
                target.removeClass('active');

                onTileUnfocus();
            } else {
                target.addClass('active');

                onTileFocus(target);
            }
        });
}

function setupHoverEvents() {
    $('.tile')
        .unbind()
        .mouseenter(function (e) {
            let target = $(this);
            onTileFocus(target);
        })
        .mouseleave(function (e) {
            onTileUnfocus();
        });
}

function onTileFocus(target) {
    let screenSizeMediaQuery = window.matchMedia("only screen and (max-width: 600px)");

    if (screenSizeMediaQuery.matches) {
        $('.tile').each(function () {
            let loopTarget = $(this);

            if (loopTarget.is(target) === false) {
                loopTarget.addClass('hide');
            }
        });
    } else {
        let topBottomClass = (target.hasClass('first-word') ? 'first-word' : 'second-word');

        $('.tile.' + topBottomClass).each(function () {
            let loopTarget = $(this);

            if (loopTarget.is(target) === false) {
                loopTarget.addClass('hide');
            }
        });
    }
}

function onTileUnfocus() {
    $('.tile').each(function () {
        $(this).removeClass('hide');
    });
}

function mediaQueryChanged() {
    $('.tile').each(function () {
        let loopTarget = $(this);
        if (loopTarget.hasClass('active')) {
            loopTarget.trigger('click');
        }
    });

    initialiseTileEvents();
}

function setupTiles() {
    randomlySizeTiles();
    initialiseTileEvents();

    var hoverQuery = window.matchMedia("(hover: hover)");
    var sizeQuery = window.matchMedia("only screen and (max-width: 600px)");
    hoverQuery.addEventListener('change', () => mediaQueryChanged());
    sizeQuery.addEventListener('change', () => mediaQueryChanged());
}