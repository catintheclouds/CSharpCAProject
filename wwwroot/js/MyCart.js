
/* Remove item from cart */
$(document).ready(function () {
    $.each($("input[name='cbx']:checked"), function () {
        checkedList.push($(this).val());
    });

    caluclateCart(checkedList);
});

var checkedList = [];
$(document).on("change", "input[name='cbx']", function () {
    //alert("FECK");
    checkedList = [];
    $.each($("input[name='cbx']:checked"), function () {
        checkedList.push($(this).val());
    });
    caluclateCart(checkedList);
});


function caluclateCart(list) {
    var finalAmount = 0;
    var i;
    for (i = 0; i < list.length; i++) {
        finalAmount = parseInt(finalAmount) + parseInt($('#CartSubtotal_' + list[i]).html());
    }
    $(".total-items").text(list.length);
    $('#basket-subtotal').html(finalAmount.toFixed(2));
    $('#final_amount').html(finalAmount.toFixed(2));

}

function CheckOut() {
    var todoIds = "";
    var amount = $('#final_amount').html();
   
    $.each($("input[name='cbx']:checked"), function () {
      
        todoIds += $(this).val() + ";";
    });

    $("#todoIds").val(todoIds);
    $("#EditForm").submit();
}



function removeItem(removeButton) {
    /* Remove row from DOM and recalc cart total */
    var productRow = $(this).parent().parent();
    productRow.slideUp(fadeTime, function () {
        productRow.remove();
        //recalculateCart();
        //updateSumItems();
    });
}

/* Update quantity */
function updateQuantity(id,price) {
   
    var cartQty = $('#cartQty_'+id).val();
  

    $("#hdcartQty_"+id).val(cartQty);
    $("#price_" + id).val(price);
    $("#qtyChangecartID_" + id).val(id);
    $("#ChangeQtyForm_"+id).submit();
   
}

//var $buttonPlus = $('.increase-btn');
//var $buttonMin = $('.decrease-btn');
//var $quantity = $('.quantity');

/*For plus and minus buttons*/
function IncreaseBtn(id, price) {
    $('#cartQty_' + id).val(parseInt($('#cartQty_' + id).val()) + 1).trigger('input');
    updateQuantity(id, price);
};

function DecreaseBtn(id, price) {
    $('#cartQty_' + id).val(Math.max(parseInt($('#cartQty_' + id).val()) - 1, 1)).trigger('input');
    updateQuantity(id, price);
};
