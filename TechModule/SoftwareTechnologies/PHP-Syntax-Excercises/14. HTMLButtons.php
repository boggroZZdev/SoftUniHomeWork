<form>
    Number of Buttons: <input type="text" name="num"/>
    <input type="submit" value="Generate buttons">
</form>
<?php
if (isset($_GET['num'])){
    $num = intval($_GET['num']);
    for ($i = 1; $i <= $num; $i++){
        echo "<button>$i</button><br>";
    }
}
