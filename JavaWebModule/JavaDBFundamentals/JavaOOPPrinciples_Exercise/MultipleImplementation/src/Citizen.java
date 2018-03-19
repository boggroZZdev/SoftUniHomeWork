public class Citizen implements Birthable, Identifiable {
    private String id;
    private String birthdate;
    private String name;
    private int age;

    public Citizen(String name, int age, String id, String birthdate) {
        this.id = id;
        this.birthdate = birthdate;
        this.name = name;
        this.age = age;
    }

    @Override
    public String getBirthdate() {
        return this.birthdate;
    }

    @Override
    public String getId() {
        return this.id;
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }
}
