let basket = JSON.parse(localStorage.getItem('basket'))
let tbody = document.getElementById('tbody')
for (let prod of basket) {

    let tr = document.createElement('tr')
     //let checkbox=document.createElement('td');
     let icontd=document.createElement('td')
    let imgtd = document.createElement('td')
    let idtd = document.createElement('td')
    let nametd = document.createElement('td')
    let quantitytd = document.createElement('td');
    // let pricetd=document.createElement('td')
    //tr.innerHTML = `<i class="fa-solid fa-trash-can trash"></i>`
    let img = document.createElement('img');


    idtd.innerText = prod.id 
    nametd.innerText = prod.name
    img.setAttribute('src', prod.img)
    imgtd.append(img);
    quantitytd.innerText = prod.count
    // pricetd.innerText=prod.price
    // checkboxtd.innerHTML=`<i class="fa-solid fa-trash-can trash"></i>`
    icontd.innerHTML=`<i class="fa-solid fa-trash-can trash"></i>`
    tr.append(imgtd, nametd, quantitytd, idtd,icontd);
    
    console.log(tr)
    tbody.append(tr);
}
let remove =document.querySelectorAll('.trash');
for(let icon of remove){
    icon.addEventListener("click", function(){
        for(let i=0; i<basket.length; i++){
            if(basket[i].id==icon.parentElement.previousElementSibling.innerText){
                basket.splice(i,1);
                localStorage.setItem("basket", JSON.stringify(basket));
                window.location.reload();
                
            }
        }
    });
  
}