function musicSticky() {
    var navigation = document.getElementById("navigation");
    var body = document.getElementById("body-container");

    navigation.classList.remove("sticky");
    body.classList.remove("sticky");

    window.onscroll = function () {
        //if ((window.innerHeight + window.scrollY) >= document.body.scrollHeight) // if scroll to bottom {
        //    navigation.classList.add("sticky");
        //}
        if (window.pageYOffset + navigation.clientHeight >= banner.scrollHeight) {
            navigation.classList.add("sticky");
        }
        else {
            navigation.classList.remove("sticky");
        }
    }
}
