<?php

/* trip/edit.html.twig */
class __TwigTemplate_563e0929cc458e9e65d8a0190be0a058f4482db4518f6656be5f9fad17fd2aa9 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "trip/edit.html.twig", 1);
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
        $__internal_73a556cde7c285eb8f018fcc9dc217f5686431890e0a7a964c6d4b8e760d04ce = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_73a556cde7c285eb8f018fcc9dc217f5686431890e0a7a964c6d4b8e760d04ce->enter($__internal_73a556cde7c285eb8f018fcc9dc217f5686431890e0a7a964c6d4b8e760d04ce_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "trip/edit.html.twig"));

        $__internal_760bc6c0013b4160d29912b1d677d4bc577105354e2b0dc43ed25cf0999f2a2d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_760bc6c0013b4160d29912b1d677d4bc577105354e2b0dc43ed25cf0999f2a2d->enter($__internal_760bc6c0013b4160d29912b1d677d4bc577105354e2b0dc43ed25cf0999f2a2d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "trip/edit.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_73a556cde7c285eb8f018fcc9dc217f5686431890e0a7a964c6d4b8e760d04ce->leave($__internal_73a556cde7c285eb8f018fcc9dc217f5686431890e0a7a964c6d4b8e760d04ce_prof);

        
        $__internal_760bc6c0013b4160d29912b1d677d4bc577105354e2b0dc43ed25cf0999f2a2d->leave($__internal_760bc6c0013b4160d29912b1d677d4bc577105354e2b0dc43ed25cf0999f2a2d_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_447f86b9ade50a68d0be996f646eca9477f79fecacd9c04abccecd76a3014127 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_447f86b9ade50a68d0be996f646eca9477f79fecacd9c04abccecd76a3014127->enter($__internal_447f86b9ade50a68d0be996f646eca9477f79fecacd9c04abccecd76a3014127_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_d5c3c1296a3431235595c9cb52024d42d4e60fddf937c1fad9234caa8494d3f2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d5c3c1296a3431235595c9cb52024d42d4e60fddf937c1fad9234caa8494d3f2->enter($__internal_d5c3c1296a3431235595c9cb52024d42d4e60fddf937c1fad9234caa8494d3f2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"trip-create\" method=\"post\">
        <div class=\"create-header\">
            Edit Trip
        </div>
        <div class=\"create-origin\">
            <div class=\"create-origin-label\">Origin</div>
            <input class=\"create-origin-content\" name=\"trip[origin]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["trip"] ?? $this->getContext($context, "trip")), "origin", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-destination\">
            <div class=\"create-destination-label\">Destination</div>
            <input class=\"create-destination-content\" name=\"trip[destination]\" value=\"";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["trip"] ?? $this->getContext($context, "trip")), "destination", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-business\">
            <div class=\"create-business-label\">Business Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-business-content\" name=\"trip[business]\" value=\"";
        // line 19
        echo twig_escape_filter($this->env, $this->getAttribute(($context["trip"] ?? $this->getContext($context, "trip")), "business", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-economy\">
            <div class=\"create-economy-label\">Economy Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-economy-content\" name=\"trip[economy]\" value=\"";
        // line 23
        echo twig_escape_filter($this->env, $this->getAttribute(($context["trip"] ?? $this->getContext($context, "trip")), "economy", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Trip</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 30
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_d5c3c1296a3431235595c9cb52024d42d4e60fddf937c1fad9234caa8494d3f2->leave($__internal_d5c3c1296a3431235595c9cb52024d42d4e60fddf937c1fad9234caa8494d3f2_prof);

        
        $__internal_447f86b9ade50a68d0be996f646eca9477f79fecacd9c04abccecd76a3014127->leave($__internal_447f86b9ade50a68d0be996f646eca9477f79fecacd9c04abccecd76a3014127_prof);

    }

    public function getTemplateName()
    {
        return "trip/edit.html.twig";
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
            Edit Trip
        </div>
        <div class=\"create-origin\">
            <div class=\"create-origin-label\">Origin</div>
            <input class=\"create-origin-content\" name=\"trip[origin]\" value=\"{{ trip.origin }}\" />
        </div>
        <div class=\"create-destination\">
            <div class=\"create-destination-label\">Destination</div>
            <input class=\"create-destination-content\" name=\"trip[destination]\" value=\"{{ trip.destination }}\" />
        </div>
        <div class=\"create-business\">
            <div class=\"create-business-label\">Business Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-business-content\" name=\"trip[business]\" value=\"{{ trip.business }}\" />
        </div>
        <div class=\"create-economy\">
            <div class=\"create-economy-label\">Economy Class Price</div>
            <input type=\"number\" min=\"0\" class=\"create-economy-content\" name=\"trip[economy]\" value=\"{{ trip.economy }}\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Trip</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}

", "trip/edit.html.twig", "C:\\Users\\user\\Desktop\\exam\\PHP-Skeleton\\app\\Resources\\views\\trip\\edit.html.twig");
    }
}
