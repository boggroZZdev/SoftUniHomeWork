<form>
    N: <input type="text" name="num1">
    M: <input type="text" name="num2">
    <input type="submit" value="Calculate"/>
</form>
<?php
if (isset($_GET['num1']) && isset($_GET['num2'])){
    $number1 = intval($_GET['num1']);
    $number2 = intval($_GET['num2']);
    echo $number1*$number2;
}