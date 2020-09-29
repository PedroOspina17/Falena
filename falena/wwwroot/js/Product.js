

function updateFinalPrice() {
    var priceList = parseInt($("#PriceList").val()) + 0;
    var expectedRevenew = parseInt($("#ExpectedRevenue").val()) + 0;
    if (priceList > 0 && expectedRevenew > 0) {
        $("#FinalPrice").val(priceList + expectedRevenew);
    }
}

function updateCurrentStock() {
    var purchases = parseInt($("#Purchases").val());
    var sales = parseInt($("#Sales").val());
    if (purchases > 0 && sales > 0) {
        $("#CurrentStock").val(purchases - sales);
    }

}