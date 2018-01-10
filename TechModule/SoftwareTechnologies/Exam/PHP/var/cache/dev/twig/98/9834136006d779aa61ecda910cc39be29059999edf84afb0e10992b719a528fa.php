<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_09886c37796d81d574b2448cf2a22ea32da8dad546b69f22c376ce19a869ce97 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_77c1ef8014f8806dc0b492426edb36f9bb82047a2844400cd3b2c4f3d247c881 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_77c1ef8014f8806dc0b492426edb36f9bb82047a2844400cd3b2c4f3d247c881->enter($__internal_77c1ef8014f8806dc0b492426edb36f9bb82047a2844400cd3b2c4f3d247c881_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_627d99d79895d6b777c12505ddce95b8966ec0ed0e2963e8839f94a663854711 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_627d99d79895d6b777c12505ddce95b8966ec0ed0e2963e8839f94a663854711->enter($__internal_627d99d79895d6b777c12505ddce95b8966ec0ed0e2963e8839f94a663854711_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_77c1ef8014f8806dc0b492426edb36f9bb82047a2844400cd3b2c4f3d247c881->leave($__internal_77c1ef8014f8806dc0b492426edb36f9bb82047a2844400cd3b2c4f3d247c881_prof);

        
        $__internal_627d99d79895d6b777c12505ddce95b8966ec0ed0e2963e8839f94a663854711->leave($__internal_627d99d79895d6b777c12505ddce95b8966ec0ed0e2963e8839f94a663854711_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_7d5ecc9e7b23a2b75180790b3e1f3120d66843ce0c1a0425e239395c944ddd36 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7d5ecc9e7b23a2b75180790b3e1f3120d66843ce0c1a0425e239395c944ddd36->enter($__internal_7d5ecc9e7b23a2b75180790b3e1f3120d66843ce0c1a0425e239395c944ddd36_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_97d6dceab942c91988b0a4cec1453ff7392f3c19fa6911b4cc71dfd7ab4bfbea = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_97d6dceab942c91988b0a4cec1453ff7392f3c19fa6911b4cc71dfd7ab4bfbea->enter($__internal_97d6dceab942c91988b0a4cec1453ff7392f3c19fa6911b4cc71dfd7ab4bfbea_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_97d6dceab942c91988b0a4cec1453ff7392f3c19fa6911b4cc71dfd7ab4bfbea->leave($__internal_97d6dceab942c91988b0a4cec1453ff7392f3c19fa6911b4cc71dfd7ab4bfbea_prof);

        
        $__internal_7d5ecc9e7b23a2b75180790b3e1f3120d66843ce0c1a0425e239395c944ddd36->leave($__internal_7d5ecc9e7b23a2b75180790b3e1f3120d66843ce0c1a0425e239395c944ddd36_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_7ee8639986141d3d8ab75c7f79f62a437379af5cfdd7452f269dd9c12119fe89 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7ee8639986141d3d8ab75c7f79f62a437379af5cfdd7452f269dd9c12119fe89->enter($__internal_7ee8639986141d3d8ab75c7f79f62a437379af5cfdd7452f269dd9c12119fe89_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_704d9dcaef94bca0efbecc7dc8e5ecf0e4752e003e90462785745dbe5daeedce = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_704d9dcaef94bca0efbecc7dc8e5ecf0e4752e003e90462785745dbe5daeedce->enter($__internal_704d9dcaef94bca0efbecc7dc8e5ecf0e4752e003e90462785745dbe5daeedce_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_704d9dcaef94bca0efbecc7dc8e5ecf0e4752e003e90462785745dbe5daeedce->leave($__internal_704d9dcaef94bca0efbecc7dc8e5ecf0e4752e003e90462785745dbe5daeedce_prof);

        
        $__internal_7ee8639986141d3d8ab75c7f79f62a437379af5cfdd7452f269dd9c12119fe89->leave($__internal_7ee8639986141d3d8ab75c7f79f62a437379af5cfdd7452f269dd9c12119fe89_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_b5352ed566d8452dee6ee48e8fe63002d5fd53bb1d5dc238cb7e85766b6bfe6e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b5352ed566d8452dee6ee48e8fe63002d5fd53bb1d5dc238cb7e85766b6bfe6e->enter($__internal_b5352ed566d8452dee6ee48e8fe63002d5fd53bb1d5dc238cb7e85766b6bfe6e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_920bd498d9689e0893fa4c230dc33817a93ba820bf9ce42a9b349986bef03708 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_920bd498d9689e0893fa4c230dc33817a93ba820bf9ce42a9b349986bef03708->enter($__internal_920bd498d9689e0893fa4c230dc33817a93ba820bf9ce42a9b349986bef03708_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_920bd498d9689e0893fa4c230dc33817a93ba820bf9ce42a9b349986bef03708->leave($__internal_920bd498d9689e0893fa4c230dc33817a93ba820bf9ce42a9b349986bef03708_prof);

        
        $__internal_b5352ed566d8452dee6ee48e8fe63002d5fd53bb1d5dc238cb7e85766b6bfe6e->leave($__internal_b5352ed566d8452dee6ee48e8fe63002d5fd53bb1d5dc238cb7e85766b6bfe6e_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "C:\\Users\\user\\Desktop\\exam\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
