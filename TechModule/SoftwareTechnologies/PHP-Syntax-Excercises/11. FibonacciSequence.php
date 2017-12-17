<form>
    N: <input type="text" name="num"/>
    <input type="submit"/>
</form>
<?php
if (isset($_GET['num'])){
    $number = intval($_GET['num']);
    $num1 = 1;
    $num2 = 1;
    echo "$num1 ";
    echo "$num2 ";
    for ($a = 2; $a < $number; $a++){
        $currentNum = $num1+$num2;
        echo "$currentNum ";
        $num1 = $num2;
        $num2 = $currentNum;
    }
}
