$(function(){
    $('#open-nav').click(function(){
        var navbar = document.querySelector(".nav-bar")
        navbar.classList.toggle('active-nav')
       
    })
    $('#close-nav').click(function(){
        var navbar=document.querySelector(".nav-bar")
        navbar.classList.toggle('active-nav')
    
    })
})