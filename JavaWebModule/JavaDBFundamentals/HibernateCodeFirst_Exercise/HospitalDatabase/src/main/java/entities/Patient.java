package entities;

import javax.persistence.*;
import java.sql.Blob;
import java.time.LocalDate;
import java.util.Date;
import java.util.Set;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

@Entity
@Table(name = "patients")
public class Patient {

    private Long id;
    private String firstName;
    private String lastName;
    private String address;
    private String email;
    private Date dateOfBirth;
    private Blob picture;
    private boolean hasMedicalInsurance;
    private Set<Visitation> visitations;
    private Set<Diagnosis> diagnoses;
    private Set<Medicament> perscribedMedicaments;

    public Patient() {
    }

    @Id
    @Column(name = "id")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    @Column(name = "first_name")
    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    @Column(name = "last_name")
    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    @Column(name = "address")
    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    @Column(name = "email")
    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    @Column(name = "date_of_birth")
    public Date getDateOfBirth() {
        return dateOfBirth;
    }

    public void setDateOfBirth(Date dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }

    @Column(name = "picture")
    public Blob getPicture() {
        return picture;
    }

    public void setPicture(Blob picture) {
        this.picture = picture;
    }

    @Column(name = "has_medical_insurance")
    public boolean hasMedicalInsurance() {
        return hasMedicalInsurance;
    }

    public void setHasMedicalInsurance(boolean hasMedicalInsurance) {
        this.hasMedicalInsurance = hasMedicalInsurance;
    }

    @OneToMany(mappedBy = "patient", targetEntity = Visitation.class, cascade = CascadeType.ALL)
    public Set<Visitation> getVisitations() {
        return visitations;
    }

    public void setVisitations(Set<Visitation> visitations) {
        this.visitations = visitations;
    }

    @ManyToMany(cascade = CascadeType.ALL)
    @JoinTable(name = "patients_diagnoses",
            joinColumns = @JoinColumn(name = "patient_id",referencedColumnName = "id"),
            inverseJoinColumns = @JoinColumn(name = "diagnosis_id",referencedColumnName = "id"))
    public Set<Diagnosis> getDiagnoses() {
        return diagnoses;
    }

    public void setDiagnoses(Set<Diagnosis> diagnoses) {
        this.diagnoses = diagnoses;
    }

    @ManyToMany(cascade = CascadeType.ALL)
    @JoinTable(name = "patients_medicaments",
            joinColumns = @JoinColumn(name = "patient_id",referencedColumnName = "id"),
            inverseJoinColumns = @JoinColumn(name = "medicament_id",referencedColumnName = "id"))
    public Set<Medicament> getPerscribedMedicaments() {
        return perscribedMedicaments;
    }

    public void setPerscribedMedicaments(Set<Medicament> perscribedMedicaments) {
        this.perscribedMedicaments = perscribedMedicaments;
    }
}