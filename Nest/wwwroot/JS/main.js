$(document).ready(function () {

    $('.news').slick({
        infinite: true,
        slidesToShow: 1,
        slidesToScroll: 1,
        vertical: true,
        autoplay: true,
        verticalSwiping: true,
        arrows: false
    });

    $('.images').slick({
        slidesToShow: 3,
        slidesToScroll: 1,
        arrows: false,
        autoplay: true,
        autoplaySpeed: 2000,
    });

    // $('#open-nav').click(function(){
    //     var navbar = document.querySelector(".nav-bar")
    //     navbar.classList.toggle('active-nav')
    // })
    // $('#close-nav').click(function(){
    //     var navbar=document.querySelector(".nav-bar")
    //     navbar.classList.toggle('active-nav')
    // })
    $('.image2').slick({
        slidesToShow: 4,
        slidesToScroll: 1,
        arrows: false,
        autoplay: true,
        autoplaySpeed: 2000,
    });
    var menus = document.querySelectorAll('.tab-menu div');
    var contents = document.querySelectorAll('.content>div');




    for (var menu of menus) {
        menu.addEventListener('click', function () {


            var index = this.getAttribute('data-index');
            for (var content of contents) {
                if (content.getAttribute('data-index') == index) {
                    content.classList.remove('d-none')
                }
                else {
                    content.classList.add('d-none');
                }
            }

        })
    }


    if (JSON.parse(localStorage.getItem('basket')) == null) {
        localStorage.setItem('basket', JSON.stringify([]))
    }

    let btnAdd = document.querySelectorAll('.btnAdd');
    for (let btn of btnAdd) {
        btn.onclick = function (e) {
            e.preventDefault();
            if (JSON.parse(localStorage.getItem('basket')) == null) {
                localStorage.setItem('basket', JSON.stringify([]))
            }
            let basket = JSON.parse(localStorage.getItem('basket'))
            let img = this.parentElement.parentElement.previousElementSibling.querySelector(".img1").getAttribute('src');
            let name = this.parentElement.parentElement.parentElement.querySelector("h6").innerText;
            let id = this.parentElement.parentElement.parentElement.getAttribute('data-id');
            // let price=this.previousElementSibling.querySelector('.price1');

            let exsistProd = basket.find(d => d.id == id);
            if (exsistProd === undefined) {
                basket.push({
                    id: id,
                    name: name,
                    img: img,
                    count: 1,
                    
                });
            }
            else {
                exsistProd.count += 1;
            }
            localStorage.setItem("basket", JSON.stringify(basket));
            countbasket();

        }

    }
    function countbasket() {
        let bucket = JSON.parse(localStorage.getItem('basket'));
        document.getElementById("productcount").innerText = bucket.length;
    }

//    $(window).scroll(function(){
//        var header =$('.trends'),
//        scroll=$(window).scrollTop();

//        if(scroll >=200)header.addClass('fixed');
//        else header.removeClass('fixed');
//    })

});
$(window).scroll(function () {
    var header = $('.trends'),
        scroll = $(window).scrollTop();
  
    if (scroll >= 150) {
        header.css({
            'position': 'fixed',
            'top': '0',
            'left': '0',
            'right': '0',
            'z-index': '99999'
        });
    } else {
        header.css({
            'position': 'relative'
        });
    }
  });
  $(window).scroll(function () {
    var header = $('#phone-header'),
      scroll = $(window).scrollTop();
  
    if (scroll >= 200) header.css({
      'position': 'fixed',
      'top': '0',
      'left': '0',
      'right': '0',
      'box-shadow': '0 8px 20px 0 rgba(0, 0, 0, 0.05)',
      'z-index': '999',
      'background-color': '#fff'
    });
    else header.css({
      'position': 'relative',
      'box-shadow': 'none'
    });
  });











