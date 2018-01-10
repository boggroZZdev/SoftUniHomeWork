package trainsystem.controller;

import trainsystem.entity.Trip;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import trainsystem.bindingModel.TripBindingModel;
import trainsystem.repository.TripRepository;

import java.util.List;

@Controller
public class TripController {
	private final TripRepository tripRepository;

	@Autowired
	public TripController(TripRepository tripRepository) {
		this.tripRepository = tripRepository;
	}

	@GetMapping("/")
	public String index(Model model) {
		List<Trip> trips = this.tripRepository.findAll();
		model.addAttribute("trips", trips);
		model.addAttribute("view", "trip/index");
		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {
		model.addAttribute("trip", new TripBindingModel());
		model.addAttribute("view", "trip/create");
		return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, TripBindingModel tripBindingModel) {
		Trip t = new Trip();
		if (tripBindingModel.getOrigin().length()<1){
			return "redirect:/create";
		}
		t.setOrigin(tripBindingModel.getOrigin());
		if (tripBindingModel.getDestination().length()<1){
			return "redirect:/create";
		}
		t.setDestination(tripBindingModel.getDestination());
		t.setBusiness(tripBindingModel.getBusiness());
		t.setEconomy(tripBindingModel.getEconomy());
		tripRepository.saveAndFlush(t);

		return "redirect:/";
	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {
		Trip trip = this.tripRepository.findOne(id);

		if (trip == null){
			return "redirect:/";
		}

		model.addAttribute("trip", trip);
		model.addAttribute("view", "trip/edit");

		return "base-layout";
	}

	@PostMapping("/edit/{id}")
	public String editProcess(@PathVariable int id, Model model, TripBindingModel tripBindingModel) {
		Trip trip = this.tripRepository.findOne(id);
		if (trip==null){
			return "redirect:/";
		}

		if (tripBindingModel.getOrigin().length()<1){
			return "redirect:/edit/{id}";
		}
		trip.setOrigin(tripBindingModel.getOrigin());
		if (tripBindingModel.getDestination().length()<1){
			return "redirect:/edit/{id}";
		}
		trip.setDestination(tripBindingModel.getDestination());
		trip.setEconomy(tripBindingModel.getEconomy());
		trip.setBusiness(tripBindingModel.getBusiness());

		tripRepository.saveAndFlush(trip);

		return "redirect:/";
	}

	@GetMapping("/delete/{id}")
	public String delete(Model model, @PathVariable int id) {
		Trip trip = this.tripRepository.findOne(id);
		if (trip == null){
			return "redirect:/";
		}

		model.addAttribute("trip", trip);
		model.addAttribute("view", "trip/delete");
		return "base-layout";
	}

	@PostMapping("/delete/{id}")
	public String deleteProcess(@PathVariable int id, TripBindingModel tripBindingModel) {
		Trip trip = this.tripRepository.findOne(id);
		if (trip == null){
			return "redirect:/";
		}
		tripRepository.delete(trip);
		tripRepository.flush();

		return "redirect:/";
	}
}
