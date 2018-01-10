<?php

/* trip/delete.html.twig */
class __TwigTemplate_81af644078b30c68bbf86c0c88b0c92c9abf502f1738ccfbfd5dee2b7e64801e extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "trip/delete.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_4c667944f929e8cba824541eccad078a4622451f9948a7e7ecdf3b51438f3744 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4c667944f929e8cba824541eccad078a4622451f9948a7e7ecdf3b51438f3744->enter($__internal_4c667944f929e8cba824541eccad078a4622451f9948a7e7ecdf3b51438f3744_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "trip/delete.html.twig"));

        $__internal_38c74cf8b77f4c55b8a199d702c1d3b15583efdfec904f5a9f6c91649d03345a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_38c74cf8b77f4c55b8a199d702c1d3b15583efdfec904f5a9f6c91649d03345a->enter($__internal_38c74cf8b77f4c55b8a199d702c1d3b15583efdfec904f5a9f6c91649d03345a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "trip/delete.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_4c667944f929e8cba824541eccad078a4622451f9948a7e7ecdf3b51438f3744->leave($__internal_4c667944f929e8cba824541eccad078a4622451f9948a7e7ecdf3b51438f3744_prof);

        
        $__internal_38c74cf8b77f4c55b8a199d702c1d3b15583efdfec904f5a9f6c91649d03345a->leave($__internal_38c74cf8b77f4c55b8a199d702c1d3b15583efdfec904f5a9f6c91649d03345a_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_727bec5e83507b96e949b5a06ac4e491b4ea73f568046478c389d6e39a837487 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_727bec5e83507b96e949b5a06ac4e491b4ea73f568046478c389d6e39a837487->enter($__internal_727bec5e83507b96e949b5a06ac4e491b4ea73f568046478c389d6e39a837487_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_0eb9a7a100e584e7bbf57e3e15ad41b7fdffd17eee559159996287f48abaf213 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0eb9a7a100e584e7bbf57e3e15ad41b7fdffd17eee559159996287f48abaf213->enter($__internal_0eb9a7a100e584e7bbf57e3e15ad41b7fdffd17eee559159996287f48abaf213_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"trip-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Trip
        </div>
        <div class=\"create-origin\">
            <div class=\"create-origin-label\">Origin</div>
            <input class=\"create-origin-content\" name=\"trip[origin]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["trip"] ?? $this->getContext($context, "trip")), "origin", array()), "html", null, true);
        echo "\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-destination\">
            <div class=\"create-destination-label\">Destination</div>
            <input class=\"create-destination-content\" name=\"trip[destination]\" value=\"";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["trip"] ?? $this->getContext($context, "trip")), "destination", array()), "html", null, true);
        echo "\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-business\">
            <div class=\"create-business-label\">Business Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-business-content\" name=\"trip[business]\" value=\"";
        // line 19
        echo twig_escape_filter($this->env, $this->getAttribute(($context["trip"] ?? $this->getContext($context, "trip")), "business", array()), "html", null, true);
        echo "\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-economy\">
            <div class=\"create-economy-label\">Economy Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-economy-content\" name=\"trip[economy]\" value=\"";
        // line 23
        echo twig_escape_filter($this->env, $this->getAttribute(($context["trip"] ?? $this->getContext($context, "trip")), "economy", array()), "html", null, true);
        echo "\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Delete Trip</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 30
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_0eb9a7a100e584e7bbf57e3e15ad41b7fdffd17eee559159996287f48abaf213->leave($__internal_0eb9a7a100e584e7bbf57e3e15ad41b7fdffd17eee559159996287f48abaf213_prof);

        
        $__internal_727bec5e83507b96e949b5a06ac4e491b4ea73f568046478c389d6e39a837487->leave($__internal_727bec5e83507b96e949b5a06ac4e491b4ea73f568046478c389d6e39a837487_prof);

    }

    public function getTemplateName()
    {
        return "trip/delete.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  89 => 30,  79 => 23,  72 => 19,  65 => 15,  58 => 11,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"trip-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Trip
        </div>
        <div class=\"create-origin\">
            <div class=\"create-origin-label\">Origin</div>
            <input class=\"create-origin-content\" name=\"trip[origin]\" value=\"{{ trip.origin }}\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-destination\">
            <div class=\"create-destination-label\">Destination</div>
            <input class=\"create-destination-content\" name=\"trip[destination]\" value=\"{{ trip.destination }}\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-business\">
            <div class=\"create-business-label\">Business Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-business-content\" name=\"trip[business]\" value=\"{{ trip.business }}\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-economy\">
            <div class=\"create-economy-label\">Economy Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-economy-content\" name=\"trip[economy]\" value=\"{{ trip.economy }}\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Delete Trip</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", "trip/delete.html.twig", "C:\\Users\\user\\Desktop\\exam\\PHP-Skeleton\\app\\Resources\\views\\trip\\delete.html.twig");
    }
}
