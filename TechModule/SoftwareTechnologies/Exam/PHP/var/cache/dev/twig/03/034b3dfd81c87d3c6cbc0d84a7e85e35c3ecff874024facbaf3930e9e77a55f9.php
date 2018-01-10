<?php

/* @WebProfiler/Profiler/open.html.twig */
class __TwigTemplate_ac12c574132227140b686f2370e565f8f8810500cd69524bf391681d60e32a52 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/base.html.twig", "@WebProfiler/Profiler/open.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_3462a28cbaa9798048c91eff1c881747889a3cef8c506e17b3a366487a5c52b5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3462a28cbaa9798048c91eff1c881747889a3cef8c506e17b3a366487a5c52b5->enter($__internal_3462a28cbaa9798048c91eff1c881747889a3cef8c506e17b3a366487a5c52b5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Profiler/open.html.twig"));

        $__internal_35e784424aff952f8b8dfaf4cf83179d4b48ec6ab27210597dde954d65e6735f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_35e784424aff952f8b8dfaf4cf83179d4b48ec6ab27210597dde954d65e6735f->enter($__internal_35e784424aff952f8b8dfaf4cf83179d4b48ec6ab27210597dde954d65e6735f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Profiler/open.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_3462a28cbaa9798048c91eff1c881747889a3cef8c506e17b3a366487a5c52b5->leave($__internal_3462a28cbaa9798048c91eff1c881747889a3cef8c506e17b3a366487a5c52b5_prof);

        
        $__internal_35e784424aff952f8b8dfaf4cf83179d4b48ec6ab27210597dde954d65e6735f->leave($__internal_35e784424aff952f8b8dfaf4cf83179d4b48ec6ab27210597dde954d65e6735f_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_5a3c6c1f8fda58eebf0525012c3b21933debc4bfa897f1660ecc27e93bded497 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_5a3c6c1f8fda58eebf0525012c3b21933debc4bfa897f1660ecc27e93bded497->enter($__internal_5a3c6c1f8fda58eebf0525012c3b21933debc4bfa897f1660ecc27e93bded497_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_8291da329534c0e87abb75dea47cb8a8b31564c7c93b688f5db44b8b2bd19da1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8291da329534c0e87abb75dea47cb8a8b31564c7c93b688f5db44b8b2bd19da1->enter($__internal_8291da329534c0e87abb75dea47cb8a8b31564c7c93b688f5db44b8b2bd19da1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <style>
        ";
        // line 5
        echo twig_include($this->env, $context, "@WebProfiler/Profiler/open.css.twig");
        echo "
    </style>
";
        
        $__internal_8291da329534c0e87abb75dea47cb8a8b31564c7c93b688f5db44b8b2bd19da1->leave($__internal_8291da329534c0e87abb75dea47cb8a8b31564c7c93b688f5db44b8b2bd19da1_prof);

        
        $__internal_5a3c6c1f8fda58eebf0525012c3b21933debc4bfa897f1660ecc27e93bded497->leave($__internal_5a3c6c1f8fda58eebf0525012c3b21933debc4bfa897f1660ecc27e93bded497_prof);

    }

    // line 9
    public function block_body($context, array $blocks = array())
    {
        $__internal_e0da73ac2f9756a9d9c1f1105b5d48b368eef4942820980a4d2603679a41fb80 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e0da73ac2f9756a9d9c1f1105b5d48b368eef4942820980a4d2603679a41fb80->enter($__internal_e0da73ac2f9756a9d9c1f1105b5d48b368eef4942820980a4d2603679a41fb80_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_c63dae1c39f596b071719122f4650f51fa2d265227c0597238700bc0e0d90c8a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c63dae1c39f596b071719122f4650f51fa2d265227c0597238700bc0e0d90c8a->enter($__internal_c63dae1c39f596b071719122f4650f51fa2d265227c0597238700bc0e0d90c8a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 10
        echo "<div class=\"header\">
    <h1>";
        // line 11
        echo twig_escape_filter($this->env, ($context["file"] ?? $this->getContext($context, "file")), "html", null, true);
        echo " <small>line ";
        echo twig_escape_filter($this->env, ($context["line"] ?? $this->getContext($context, "line")), "html", null, true);
        echo "</small></h1>
    <a class=\"doc\" href=\"https://symfony.com/doc/";
        // line 12
        echo twig_escape_filter($this->env, twig_constant("Symfony\\Component\\HttpKernel\\Kernel::VERSION"), "html", null, true);
        echo "/reference/configuration/framework.html#ide\" rel=\"help\">Open in your IDE?</a>
</div>
<div class=\"source\">
    ";
        // line 15
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\CodeExtension')->fileExcerpt(($context["filename"] ?? $this->getContext($context, "filename")), ($context["line"] ?? $this->getContext($context, "line")),  -1);
        echo "
</div>
";
        
        $__internal_c63dae1c39f596b071719122f4650f51fa2d265227c0597238700bc0e0d90c8a->leave($__internal_c63dae1c39f596b071719122f4650f51fa2d265227c0597238700bc0e0d90c8a_prof);

        
        $__internal_e0da73ac2f9756a9d9c1f1105b5d48b368eef4942820980a4d2603679a41fb80->leave($__internal_e0da73ac2f9756a9d9c1f1105b5d48b368eef4942820980a4d2603679a41fb80_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Profiler/open.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  90 => 15,  84 => 12,  78 => 11,  75 => 10,  66 => 9,  53 => 5,  50 => 4,  41 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/base.html.twig' %}

{% block head %}
    <style>
        {{ include('@WebProfiler/Profiler/open.css.twig') }}
    </style>
{% endblock %}

{% block body %}
<div class=\"header\">
    <h1>{{ file }} <small>line {{ line }}</small></h1>
    <a class=\"doc\" href=\"https://symfony.com/doc/{{ constant('Symfony\\\\Component\\\\HttpKernel\\\\Kernel::VERSION') }}/reference/configuration/framework.html#ide\" rel=\"help\">Open in your IDE?</a>
</div>
<div class=\"source\">
    {{ filename|file_excerpt(line, -1) }}
</div>
{% endblock %}
", "@WebProfiler/Profiler/open.html.twig", "C:\\Users\\user\\Desktop\\exam\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Profiler\\open.html.twig");
    }
}
