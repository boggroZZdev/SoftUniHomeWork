<?php

/* trip/create.html.twig */
class __TwigTemplate_5d21207321ef00b7cd2a8327ba76fbef36a135113c88436cb4a8fadb99c855b9 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "trip/create.html.twig", 1);
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
        $__internal_d485b4cf55d2d75a36f34d5ff2188ab64089f20e0ed5e09ed4e53a83a1f70bc7 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d485b4cf55d2d75a36f34d5ff2188ab64089f20e0ed5e09ed4e53a83a1f70bc7->enter($__internal_d485b4cf55d2d75a36f34d5ff2188ab64089f20e0ed5e09ed4e53a83a1f70bc7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "trip/create.html.twig"));

        $__internal_1326ebcf7267196593f4261ca1196a78986dc9457d8fc8d78e06a1aef2e9b415 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1326ebcf7267196593f4261ca1196a78986dc9457d8fc8d78e06a1aef2e9b415->enter($__internal_1326ebcf7267196593f4261ca1196a78986dc9457d8fc8d78e06a1aef2e9b415_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "trip/create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_d485b4cf55d2d75a36f34d5ff2188ab64089f20e0ed5e09ed4e53a83a1f70bc7->leave($__internal_d485b4cf55d2d75a36f34d5ff2188ab64089f20e0ed5e09ed4e53a83a1f70bc7_prof);

        
        $__internal_1326ebcf7267196593f4261ca1196a78986dc9457d8fc8d78e06a1aef2e9b415->leave($__internal_1326ebcf7267196593f4261ca1196a78986dc9457d8fc8d78e06a1aef2e9b415_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_1f6c02a7a0ec6f1c83427c5a7ef83d063dc6f916026634464887756bd355be21 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1f6c02a7a0ec6f1c83427c5a7ef83d063dc6f916026634464887756bd355be21->enter($__internal_1f6c02a7a0ec6f1c83427c5a7ef83d063dc6f916026634464887756bd355be21_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_cbd1f0deb01bfe943653eaa3de5d5df489df57b31aa1516da82118a8275d734b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cbd1f0deb01bfe943653eaa3de5d5df489df57b31aa1516da82118a8275d734b->enter($__internal_cbd1f0deb01bfe943653eaa3de5d5df489df57b31aa1516da82118a8275d734b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"trip-create\" method=\"post\">
        <div class=\"create-header\">
            Create Trip
        </div>
        <div class=\"create-origin\">
            <div class=\"create-origin-label\">Origin</div>
            <input class=\"create-origin-content\" name=\"trip[origin]\" />
        </div>
        <div class=\"create-destination\">
            <div class=\"create-destination-label\">Destination</div>
            <input class=\"create-destination-content\" name=\"trip[destination]\" />
        </div>
        <div class=\"create-business\">
            <div class=\"create-business-label\">Business Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-business-content\" name=\"trip[business]\" />
        </div>
        <div class=\"create-economy\">
            <div class=\"create-economy-label\">Economy Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-economy-content\" name=\"trip[economy]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Trip</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 30
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_cbd1f0deb01bfe943653eaa3de5d5df489df57b31aa1516da82118a8275d734b->leave($__internal_cbd1f0deb01bfe943653eaa3de5d5df489df57b31aa1516da82118a8275d734b_prof);

        
        $__internal_1f6c02a7a0ec6f1c83427c5a7ef83d063dc6f916026634464887756bd355be21->leave($__internal_1f6c02a7a0ec6f1c83427c5a7ef83d063dc6f916026634464887756bd355be21_prof);

    }

    public function getTemplateName()
    {
        return "trip/create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  77 => 30,  49 => 4,  40 => 3,  11 => 1,);
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
            Create Trip
        </div>
        <div class=\"create-origin\">
            <div class=\"create-origin-label\">Origin</div>
            <input class=\"create-origin-content\" name=\"trip[origin]\" />
        </div>
        <div class=\"create-destination\">
            <div class=\"create-destination-label\">Destination</div>
            <input class=\"create-destination-content\" name=\"trip[destination]\" />
        </div>
        <div class=\"create-business\">
            <div class=\"create-business-label\">Business Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-business-content\" name=\"trip[business]\" />
        </div>
        <div class=\"create-economy\">
            <div class=\"create-economy-label\">Economy Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-economy-content\" name=\"trip[economy]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Trip</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", "trip/create.html.twig", "C:\\Users\\user\\Desktop\\exam\\PHP-Skeleton\\app\\Resources\\views\\trip\\create.html.twig");
    }
}
