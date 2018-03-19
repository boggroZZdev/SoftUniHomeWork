public class Citizen extends LivingBeing {

    public Citizen(String name, String birthday) {
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
