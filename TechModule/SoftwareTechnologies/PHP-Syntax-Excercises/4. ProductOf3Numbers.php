<form>
    X: <input type="text" name="num1">
    Y: <input type="text" name="num2">
    Z: <input type="text" name="num3">
    <input type="submit" value="GET PRODUCT">
</form>
<?php
if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
    $x = intval($_GET['num1']);
    $y = intval($_GET['num2']);
    $z = intval($_GET['num3']);
    if ($x == 0 || $y == 0 || $z == 0) {
        echo "Positive";
    } else {
        $numArr = array($x, $y, $z);
        $counter = 0;
        foreach ($numArr as $num){
            if ($num < 0){
                $counter++;
            }
        }
        if ($counter%2 == 0){
            echo "Positive";
        }else{
            echo "Negative";
        }
        }
}
