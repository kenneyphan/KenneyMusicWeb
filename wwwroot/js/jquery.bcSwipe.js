/**
 * Bootstrap Carousel Swipe v1.1
 *
 * jQuery plugin to enable swipe gestures on Bootstrap 3 carousels.
 * Examples and documentation: https://github.com/maaaaark/bcSwipe
 *
 * Licensed under the MIT license.
 */
(function ($) {
    console.log("inside this bich");
    $.fn.bcSwipe = function (settings) {
        var config = { threshold: 50 };
        if (settings) {
            $.extend(config, settings);
        }

        this.each(function () {
            var stillMoving = false;
            var start;

            if ('ontouchstart' in document.documentElement) {
                this.addEventListener('touchstart', onTouchStart, false);
            }

            function onTouchStart(e) {
                if (e.touches.length == 1) {
                    start = e.touches[0].pageX;
                    stillMoving = true;
                    this.addEventListener('touchmove', onTouchMove, false);
                }
            }

            function onTouchMove(e) {
                if (stillMoving) {
                    var x = e.touches[0].pageX;
                    var difference = start - x;
                    if (Math.abs(difference) >= config.threshold) {
                        cancelTouch();
                        if (isCarouselEmpty($(this))) return;
                        if (difference > 0) {
                            $(this).carousel('next');
                        }
                        else {
                            $(this).carousel('prev');
                        }
                    }
                }
            }

            function isCarouselEmpty(carousel) {
                return carousel.find(".item.active").length < 1
            }

            function cancelTouch() {
                this.removeEventListener('touchmove', onTouchMove);
                start = null;
                stillMoving = false;
            }
        });

        return this;
    };
})(jQuery);

function mobileSwipe() {
    $('.carousel').bcSwipe({ threshold: 50 });
}

//function mobileSwipe() {
//    let touchstartX = 0
//    let touchendX = 0

//    const slider = document.getElementById('slider')

//    function handleGesture() {
//        if (touchendX < touchstartX) {
//            $('.carousel').bcSwipe({ threshold: 50 });
//        }
//        //alert('swiped left!')
//        if (touchendX > touchstartX) {
//            $('.carousel').bcSwipe({ threshold: 50 });
//        }
//        //alert('swiped right!')
//    }

//    slider.addEventListener('touchstart', e => {
//        touchstartX = e.changedTouches[0].screenX
//    })

//    slider.addEventListener('touchend', e => {
//        touchendX = e.changedTouches[0].screenX
//        handleGesture()
//    })
//}