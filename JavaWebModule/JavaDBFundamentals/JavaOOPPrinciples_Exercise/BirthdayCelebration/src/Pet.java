public class Pet extends LivingBeing {


    public Pet(String name, String birthday) {
        this.setName(name);
        this.setBirthdayDate(birthday);
    }

    @Override
    public String getName() {
        return super.getName();
    }

    @Override
    public String getBirthdayDate() {
        return super.getBirthdayDate();
    }
}
