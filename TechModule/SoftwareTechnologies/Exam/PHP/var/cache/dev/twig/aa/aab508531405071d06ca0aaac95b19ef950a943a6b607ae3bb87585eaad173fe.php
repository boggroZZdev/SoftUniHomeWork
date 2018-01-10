<?php

/* trip/index.html.twig */
class __TwigTemplate_a4d44895e026a0ef44a44ec4756133d4d46c38aaa0939124f3f907f451b73eed extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "trip/index.html.twig", 1);
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
        $__internal_496e0f32aa9c85c2a0fe136fc8390457fb32d23ae6e60a456eeea1dd4b6b2559 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_496e0f32aa9c85c2a0fe136fc8390457fb32d23ae6e60a456eeea1dd4b6b2559->enter($__internal_496e0f32aa9c85c2a0fe136fc8390457fb32d23ae6e60a456eeea1dd4b6b2559_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "trip/index.html.twig"));

        $__internal_bdded3a2d80d6fd197c94aaafe40c5e2ae580ddd67109fed423b2c898b35ddc6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bdded3a2d80d6fd197c94aaafe40c5e2ae580ddd67109fed423b2c898b35ddc6->enter($__internal_bdded3a2d80d6fd197c94aaafe40c5e2ae580ddd67109fed423b2c898b35ddc6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "trip/index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_496e0f32aa9c85c2a0fe136fc8390457fb32d23ae6e60a456eeea1dd4b6b2559->leave($__internal_496e0f32aa9c85c2a0fe136fc8390457fb32d23ae6e60a456eeea1dd4b6b2559_prof);

        
        $__internal_bdded3a2d80d6fd197c94aaafe40c5e2ae580ddd67109fed423b2c898b35ddc6->leave($__internal_bdded3a2d80d6fd197c94aaafe40c5e2ae580ddd67109fed423b2c898b35ddc6_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_d7a6cf686f2e7368cf86fd0aed96c43a426f43655dce2fec8a7b41c0d5a1d21a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d7a6cf686f2e7368cf86fd0aed96c43a426f43655dce2fec8a7b41c0d5a1d21a->enter($__internal_d7a6cf686f2e7368cf86fd0aed96c43a426f43655dce2fec8a7b41c0d5a1d21a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_943982aece60d880370b92e196c3c3628b8a022b3e8c325e9ea2260338c1cc8a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_943982aece60d880370b92e196c3c3628b8a022b3e8c325e9ea2260338c1cc8a->enter($__internal_943982aece60d880370b92e196c3c3628b8a022b3e8c325e9ea2260338c1cc8a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <div class=\"button-holder\">
        <a type=\"button\" href=\"/create\" class=\"log-button\">Create New Trip</a>
    </div>
    <div class=\"content\">
        <div class=\"header\">
            <div class=\"project-label\">Origin</div>
            <div class=\"budget-label\">Destination</div>
            <div class=\"actions-label\">Actions</div>
        </div>
        <div class=\"main\">
            ";
        // line 15
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["trips"] ?? $this->getContext($context, "trips")));
        foreach ($context['_seq'] as $context["_key"] => $context["trip"]) {
            // line 16
            echo "                <div class=\"trip\">
                    <div class=\"trip-origin\">
                        ";
            // line 18
            echo twig_escape_filter($this->env, $this->getAttribute($context["trip"], "origin", array()), "html", null, true);
            echo "
                    </div>
                    <div class=\"trip-destination\">
                        ";
            // line 21
            echo twig_escape_filter($this->env, $this->getAttribute($context["trip"], "destination", array()), "html", null, true);
            echo "
                    </div>
                    <div class=\"trip-actions\">
                        <a type=\"button\" href=\"";
            // line 24
            echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("edit", array("id" => $this->getAttribute($context["trip"], "id", array()))), "html", null, true);
            echo "\" class=\"edit-button\">Edit</a>
                        <a type=\"button\" href=\"";
            // line 25
            echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("delete", array("id" => $this->getAttribute($context["trip"], "id", array()))), "html", null, true);
            echo "\" class=\"delete-button\">Delete</a>
                    </div>
                </div>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['trip'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 29
        echo "        </div>
    </div>
</div>
";
        
        $__internal_943982aece60d880370b92e196c3c3628b8a022b3e8c325e9ea2260338c1cc8a->leave($__internal_943982aece60d880370b92e196c3c3628b8a022b3e8c325e9ea2260338c1cc8a_prof);

        
        $__internal_d7a6cf686f2e7368cf86fd0aed96c43a426f43655dce2fec8a7b41c0d5a1d21a->leave($__internal_d7a6cf686f2e7368cf86fd0aed96c43a426f43655dce2fec8a7b41c0d5a1d21a_prof);

    }

    public function getTemplateName()
    {
        return "trip/index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  96 => 29,  86 => 25,  82 => 24,  76 => 21,  70 => 18,  66 => 16,  62 => 15,  49 => 4,  40 => 3,  11 => 1,);
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
    <div class=\"button-holder\">
        <a type=\"button\" href=\"/create\" class=\"log-button\">Create New Trip</a>
    </div>
    <div class=\"content\">
        <div class=\"header\">
            <div class=\"project-label\">Origin</div>
            <div class=\"budget-label\">Destination</div>
            <div class=\"actions-label\">Actions</div>
        </div>
        <div class=\"main\">
            {% for trip in trips %}
                <div class=\"trip\">
                    <div class=\"trip-origin\">
                        {{ trip.origin }}
                    </div>
                    <div class=\"trip-destination\">
                        {{ trip.destination }}
                    </div>
                    <div class=\"trip-actions\">
                        <a type=\"button\" href=\"{{ path('edit', {id: trip.id}) }}\" class=\"edit-button\">Edit</a>
                        <a type=\"button\" href=\"{{ path('delete', {id: trip.id}) }}\" class=\"delete-button\">Delete</a>
                    </div>
                </div>
            {% endfor %}
        </div>
    </div>
</div>
{% endblock %}", "trip/index.html.twig", "C:\\Users\\user\\Desktop\\exam\\PHP-Skeleton\\app\\Resources\\views\\trip\\index.html.twig");
    }
}
