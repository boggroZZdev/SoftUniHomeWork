<form>
    N: <input type="text" name="num"/>
    <input type="submit"/>
</form>
<?php
if (isset($_GET['num'])){
    $number = intval($_GET['num']);
    $num1 = 1;
    $num2 = 1;
    $num3 = 2;
    echo "$num1 ";
    echo "$num2 ";
    echo "$num3 ";
    for ($a = 3; $a < $number; $a++){
        $currentNum = $num1+$num2+$num3;
        echo "$currentNum ";
        $num1 = $num2;
        $num2 = $num3;
        $num3 = $currentNum;
    }
}
