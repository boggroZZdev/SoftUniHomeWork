<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_f32ad73c9bc804e7d7685ce925e27ce9c7daa98efc0b9a8c89227d7076a75563 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_9ee5d3cfad72f4f350890b5246adc7bc15efccfd162cd40114303138301c2769 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_9ee5d3cfad72f4f350890b5246adc7bc15efccfd162cd40114303138301c2769->enter($__internal_9ee5d3cfad72f4f350890b5246adc7bc15efccfd162cd40114303138301c2769_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_ca3331c1f1c3d799eab35e02698df529b5a6a5964e28fc49251bad9b7a1135c8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ca3331c1f1c3d799eab35e02698df529b5a6a5964e28fc49251bad9b7a1135c8->enter($__internal_ca3331c1f1c3d799eab35e02698df529b5a6a5964e28fc49251bad9b7a1135c8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_9ee5d3cfad72f4f350890b5246adc7bc15efccfd162cd40114303138301c2769->leave($__internal_9ee5d3cfad72f4f350890b5246adc7bc15efccfd162cd40114303138301c2769_prof);

        
        $__internal_ca3331c1f1c3d799eab35e02698df529b5a6a5964e28fc49251bad9b7a1135c8->leave($__internal_ca3331c1f1c3d799eab35e02698df529b5a6a5964e28fc49251bad9b7a1135c8_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_739e89c282c9d166cd7fda1105f69778dfc927ca41e33be0d04f80b94b9565d3 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_739e89c282c9d166cd7fda1105f69778dfc927ca41e33be0d04f80b94b9565d3->enter($__internal_739e89c282c9d166cd7fda1105f69778dfc927ca41e33be0d04f80b94b9565d3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_3dda268a38bb3115ba1b468c5a10575564c277cdea3eff85410bfcedfcbf6bfb = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3dda268a38bb3115ba1b468c5a10575564c277cdea3eff85410bfcedfcbf6bfb->enter($__internal_3dda268a38bb3115ba1b468c5a10575564c277cdea3eff85410bfcedfcbf6bfb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_3dda268a38bb3115ba1b468c5a10575564c277cdea3eff85410bfcedfcbf6bfb->leave($__internal_3dda268a38bb3115ba1b468c5a10575564c277cdea3eff85410bfcedfcbf6bfb_prof);

        
        $__internal_739e89c282c9d166cd7fda1105f69778dfc927ca41e33be0d04f80b94b9565d3->leave($__internal_739e89c282c9d166cd7fda1105f69778dfc927ca41e33be0d04f80b94b9565d3_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_1a38c1f64f7271c9b6ffa73a94d839a7f44d950f4ea71157a356561d101d5d9e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1a38c1f64f7271c9b6ffa73a94d839a7f44d950f4ea71157a356561d101d5d9e->enter($__internal_1a38c1f64f7271c9b6ffa73a94d839a7f44d950f4ea71157a356561d101d5d9e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_8671407eacfb0c2075deda9dbb26c3f31c071f9308cf3e61e6c960169865b30d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8671407eacfb0c2075deda9dbb26c3f31c071f9308cf3e61e6c960169865b30d->enter($__internal_8671407eacfb0c2075deda9dbb26c3f31c071f9308cf3e61e6c960169865b30d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_8671407eacfb0c2075deda9dbb26c3f31c071f9308cf3e61e6c960169865b30d->leave($__internal_8671407eacfb0c2075deda9dbb26c3f31c071f9308cf3e61e6c960169865b30d_prof);

        
        $__internal_1a38c1f64f7271c9b6ffa73a94d839a7f44d950f4ea71157a356561d101d5d9e->leave($__internal_1a38c1f64f7271c9b6ffa73a94d839a7f44d950f4ea71157a356561d101d5d9e_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_80ae1cfb786e786c97675a5ac0a9321a1e1db2d73785019301b8239ced9946f8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_80ae1cfb786e786c97675a5ac0a9321a1e1db2d73785019301b8239ced9946f8->enter($__internal_80ae1cfb786e786c97675a5ac0a9321a1e1db2d73785019301b8239ced9946f8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_0e951f6ad907bdb67b6b9693f94a6fc2d20011267d83e046b7fab8e2b7fefd5d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0e951f6ad907bdb67b6b9693f94a6fc2d20011267d83e046b7fab8e2b7fefd5d->enter($__internal_0e951f6ad907bdb67b6b9693f94a6fc2d20011267d83e046b7fab8e2b7fefd5d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_0e951f6ad907bdb67b6b9693f94a6fc2d20011267d83e046b7fab8e2b7fefd5d->leave($__internal_0e951f6ad907bdb67b6b9693f94a6fc2d20011267d83e046b7fab8e2b7fefd5d_prof);

        
        $__internal_80ae1cfb786e786c97675a5ac0a9321a1e1db2d73785019301b8239ced9946f8->leave($__internal_80ae1cfb786e786c97675a5ac0a9321a1e1db2d73785019301b8239ced9946f8_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
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

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "C:\\Users\\user\\Desktop\\exam\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
