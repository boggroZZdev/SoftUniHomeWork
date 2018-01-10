<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_4df9382f3d6170edb611daadb6ea63f895af7cb2c4bef1d3157a681bccd5e710 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4df9382f3d6170edb611daadb6ea63f895af7cb2c4bef1d3157a681bccd5e710->enter($__internal_4df9382f3d6170edb611daadb6ea63f895af7cb2c4bef1d3157a681bccd5e710_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_91d2328c08a0bb8e254ab3f99303877a2dc141581243589bdeb250f10ca3931b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_91d2328c08a0bb8e254ab3f99303877a2dc141581243589bdeb250f10ca3931b->enter($__internal_91d2328c08a0bb8e254ab3f99303877a2dc141581243589bdeb250f10ca3931b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>";
        // line 10
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 11
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 20
        $this->displayBlock('body', $context, $blocks);
        // line 23
        echo "</body>
</html>
";
        
        $__internal_4df9382f3d6170edb611daadb6ea63f895af7cb2c4bef1d3157a681bccd5e710->leave($__internal_4df9382f3d6170edb611daadb6ea63f895af7cb2c4bef1d3157a681bccd5e710_prof);

        
        $__internal_91d2328c08a0bb8e254ab3f99303877a2dc141581243589bdeb250f10ca3931b->leave($__internal_91d2328c08a0bb8e254ab3f99303877a2dc141581243589bdeb250f10ca3931b_prof);

    }

    // line 10
    public function block_title($context, array $blocks = array())
    {
        $__internal_f8f28fa1cf7c16d4b85b3babefccc39aac64fc09cf1ae00d49b5fce467bd1df4 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f8f28fa1cf7c16d4b85b3babefccc39aac64fc09cf1ae00d49b5fce467bd1df4->enter($__internal_f8f28fa1cf7c16d4b85b3babefccc39aac64fc09cf1ae00d49b5fce467bd1df4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_2056fc8df64d6e6d2d6e06a5ed5373aa4cf66c15ad1fbac375741c21d9dd766f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2056fc8df64d6e6d2d6e06a5ed5373aa4cf66c15ad1fbac375741c21d9dd766f->enter($__internal_2056fc8df64d6e6d2d6e06a5ed5373aa4cf66c15ad1fbac375741c21d9dd766f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Train System";
        
        $__internal_2056fc8df64d6e6d2d6e06a5ed5373aa4cf66c15ad1fbac375741c21d9dd766f->leave($__internal_2056fc8df64d6e6d2d6e06a5ed5373aa4cf66c15ad1fbac375741c21d9dd766f_prof);

        
        $__internal_f8f28fa1cf7c16d4b85b3babefccc39aac64fc09cf1ae00d49b5fce467bd1df4->leave($__internal_f8f28fa1cf7c16d4b85b3babefccc39aac64fc09cf1ae00d49b5fce467bd1df4_prof);

    }

    // line 11
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_7a8ce63912a24d9ebda906f68940dd29ad6da60ec107fa16ed3babc2d36225e6 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7a8ce63912a24d9ebda906f68940dd29ad6da60ec107fa16ed3babc2d36225e6->enter($__internal_7a8ce63912a24d9ebda906f68940dd29ad6da60ec107fa16ed3babc2d36225e6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_13214f83ca87b1595085fc03e232b6c1f2940c2801dbb29bdd845286bceb7f09 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_13214f83ca87b1595085fc03e232b6c1f2940c2801dbb29bdd845286bceb7f09->enter($__internal_13214f83ca87b1595085fc03e232b6c1f2940c2801dbb29bdd845286bceb7f09_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 12
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/reset.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/create-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_13214f83ca87b1595085fc03e232b6c1f2940c2801dbb29bdd845286bceb7f09->leave($__internal_13214f83ca87b1595085fc03e232b6c1f2940c2801dbb29bdd845286bceb7f09_prof);

        
        $__internal_7a8ce63912a24d9ebda906f68940dd29ad6da60ec107fa16ed3babc2d36225e6->leave($__internal_7a8ce63912a24d9ebda906f68940dd29ad6da60ec107fa16ed3babc2d36225e6_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_31154041fbaec19f2db2eff3cd63f74104e006b3e776a225a17be40c5d62de79 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_31154041fbaec19f2db2eff3cd63f74104e006b3e776a225a17be40c5d62de79->enter($__internal_31154041fbaec19f2db2eff3cd63f74104e006b3e776a225a17be40c5d62de79_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_425bdf0d9114a0dc1a5338a6094064aa83094541beacb6f19d552880d4dfcd5c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_425bdf0d9114a0dc1a5338a6094064aa83094541beacb6f19d552880d4dfcd5c->enter($__internal_425bdf0d9114a0dc1a5338a6094064aa83094541beacb6f19d552880d4dfcd5c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_425bdf0d9114a0dc1a5338a6094064aa83094541beacb6f19d552880d4dfcd5c->leave($__internal_425bdf0d9114a0dc1a5338a6094064aa83094541beacb6f19d552880d4dfcd5c_prof);

        
        $__internal_31154041fbaec19f2db2eff3cd63f74104e006b3e776a225a17be40c5d62de79->leave($__internal_31154041fbaec19f2db2eff3cd63f74104e006b3e776a225a17be40c5d62de79_prof);

    }

    // line 20
    public function block_body($context, array $blocks = array())
    {
        $__internal_fdb6d87efb9fe8f40dc06601f64805aa61d59818df0be1aba8d6feb8bafe9961 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_fdb6d87efb9fe8f40dc06601f64805aa61d59818df0be1aba8d6feb8bafe9961->enter($__internal_fdb6d87efb9fe8f40dc06601f64805aa61d59818df0be1aba8d6feb8bafe9961_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_ea0913318eddb4822c9dc948fa9588c49c6a18a1bb3c5b6963bbb49c35a9019b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ea0913318eddb4822c9dc948fa9588c49c6a18a1bb3c5b6963bbb49c35a9019b->enter($__internal_ea0913318eddb4822c9dc948fa9588c49c6a18a1bb3c5b6963bbb49c35a9019b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 21
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_ea0913318eddb4822c9dc948fa9588c49c6a18a1bb3c5b6963bbb49c35a9019b->leave($__internal_ea0913318eddb4822c9dc948fa9588c49c6a18a1bb3c5b6963bbb49c35a9019b_prof);

        
        $__internal_fdb6d87efb9fe8f40dc06601f64805aa61d59818df0be1aba8d6feb8bafe9961->leave($__internal_fdb6d87efb9fe8f40dc06601f64805aa61d59818df0be1aba8d6feb8bafe9961_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_8dcad8a76400d93c3e46c2c45e009803ae77a11e2703318a8e086590363ecee0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8dcad8a76400d93c3e46c2c45e009803ae77a11e2703318a8e086590363ecee0->enter($__internal_8dcad8a76400d93c3e46c2c45e009803ae77a11e2703318a8e086590363ecee0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_af493da8898cb10e6679d2481d39930551d1b00edba89cdac58bb8e5f4196641 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_af493da8898cb10e6679d2481d39930551d1b00edba89cdac58bb8e5f4196641->enter($__internal_af493da8898cb10e6679d2481d39930551d1b00edba89cdac58bb8e5f4196641_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_af493da8898cb10e6679d2481d39930551d1b00edba89cdac58bb8e5f4196641->leave($__internal_af493da8898cb10e6679d2481d39930551d1b00edba89cdac58bb8e5f4196641_prof);

        
        $__internal_8dcad8a76400d93c3e46c2c45e009803ae77a11e2703318a8e086590363ecee0->leave($__internal_8dcad8a76400d93c3e46c2c45e009803ae77a11e2703318a8e086590363ecee0_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  141 => 21,  132 => 20,  115 => 19,  103 => 14,  99 => 13,  94 => 12,  85 => 11,  67 => 10,  55 => 23,  53 => 20,  49 => 19,  42 => 16,  40 => 11,  36 => 10,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>{% block title %}Train System{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/reset.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/create-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "C:\\Users\\user\\Desktop\\exam\\PHP-Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}
