// Auto generated by ./transform.js
using System.Text.RegularExpressions;

namespace PrismSharp.Core.Languages;

// From https://github.com/PrismJS/prism/blob/master/components/prism-cpp.js

public class Cpp : IGrammarDefinition
{
    public Grammar Define()
    {
        var grammar = new Grammar();

        grammar["comment"] = new GrammarToken[]
        {

        new(@"\/\/(?:[^\r\n\\]|\\(?:\r\n?|\n|(?![\r\n])))*|\/\*[\s\S]*?(?:\*\/|$)", lookbehind: false, greedy: true),
        };
        grammar["char"] = new GrammarToken[]
        {

        new(@"'(?:\\(?:\r\n|[\s\S])|[^'\\\r\n]){0,32}'", lookbehind: false, greedy: true),
        };
        grammar["macro"] = new GrammarToken[]
        {

        new(new Regex(@"(^[\t ]*)#\s*[a-z](?:[^\r\n\\/]|\/(?!\*)|\/\*(?:[^*]|\*(?!\/))*\*\/|\\(?:\r\n|[\s\S]))*", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline), lookbehind: true, greedy: true, alias: new []{"property" }, inside: new Grammar
  {
      ["string"] = new GrammarToken[]
      {

        new(@"^(#\s*include\s*)<[^>]+>", lookbehind: true, greedy: false),
        new(@"""(?:\\(?:\r\n|[\s\S])|[^""\\\r\n])*""", lookbehind: false, greedy: true),
      },
      ["char"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["comment"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["macro-name"] = new GrammarToken[]
      {

        new(new Regex(@"(^#\s*define\s+)\w+\b(?!\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: true, greedy: false),
        new(new Regex(@"(^#\s*define\s+)\w+\b(?=\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: true, greedy: false, alias: new []{"function" }),
      },
      ["directive"] = new GrammarToken[]
      {

        new(@"^(#\s*)[a-z]+", lookbehind: true, greedy: false, alias: new []{"keyword" }),
      },
      ["directive-hash"] = new GrammarToken[]
      {

        new(@"^#", lookbehind: false, greedy: false),
      },
      ["punctuation"] = new GrammarToken[]
      {

        new(@"##|\\(?=[\r\n])", lookbehind: false, greedy: false),
      },
      ["expression"] = new GrammarToken[]
      {

        new(@"\S[\s\S]*", lookbehind: false, greedy: false, inside: null! /* see below */),
      },
  }),
        };
        grammar["module"] = new GrammarToken[]
        {

        new(@"(\b(?:import|module)\s+)(?:""(?:\\(?:\r\n|[\s\S])|[^""\\\r\n])*""|<[^<>\r\n]*>|\b(?!\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b)\w+(?:\s*\.\s*\w+)*\b(?:\s*:\s*\b(?!\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b)\w+(?:\s*\.\s*\w+)*\b)?|:\s*\b(?!\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b)\w+(?:\s*\.\s*\w+)*\b)", lookbehind: true, greedy: true, inside: new Grammar
  {
      ["string"] = new GrammarToken[]
      {

        new(@"^[<""][\s\S]+", lookbehind: false, greedy: false),
      },
      ["operator"] = new GrammarToken[]
      {

        new(@":", lookbehind: false, greedy: false),
      },
      ["punctuation"] = new GrammarToken[]
      {

        new(@"\.", lookbehind: false, greedy: false),
      },
  }),
        };
        grammar["raw-string"] = new GrammarToken[]
        {

        new(@"R""([^()\\ ]{0,16})\([\s\S]*?\)\1""", lookbehind: false, greedy: true, alias: new []{"string" }),
        };
        grammar["string"] = new GrammarToken[]
        {

        null! /* see below */,
        };
        grammar["base-clause"] = new GrammarToken[]
        {

        new(@"(\b(?:class|struct)\s+\w+\s*:\s*)[^;{}""'\s]+(?:\s+[^;{}""'\s]+)*(?=\s*[;{])", lookbehind: true, greedy: true, inside: new Grammar
  {
      ["comment"] = new GrammarToken[]
      {

        new(@"\/\/(?:[^\r\n\\]|\\(?:\r\n?|\n|(?![\r\n])))*|\/\*[\s\S]*?(?:\*\/|$)", lookbehind: false, greedy: true),
      },
      ["char"] = new GrammarToken[]
      {

        new(@"'(?:\\(?:\r\n|[\s\S])|[^'\\\r\n]){0,32}'", lookbehind: false, greedy: true),
      },
      ["macro"] = new GrammarToken[]
      {

        new(new Regex(@"(^[\t ]*)#\s*[a-z](?:[^\r\n\\/]|\/(?!\*)|\/\*(?:[^*]|\*(?!\/))*\*\/|\\(?:\r\n|[\s\S]))*", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline), lookbehind: true, greedy: true, alias: new []{"property" }, inside: new Grammar
  {
      ["string"] = new GrammarToken[]
      {

        new(@"^(#\s*include\s*)<[^>]+>", lookbehind: true, greedy: false),
        new(@"""(?:\\(?:\r\n|[\s\S])|[^""\\\r\n])*""", lookbehind: false, greedy: true),
      },
      ["char"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["comment"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["macro-name"] = new GrammarToken[]
      {

        new(new Regex(@"(^#\s*define\s+)\w+\b(?!\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: true, greedy: false),
        new(new Regex(@"(^#\s*define\s+)\w+\b(?=\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: true, greedy: false, alias: new []{"function" }),
      },
      ["directive"] = new GrammarToken[]
      {

        new(@"^(#\s*)[a-z]+", lookbehind: true, greedy: false, alias: new []{"keyword" }),
      },
      ["directive-hash"] = new GrammarToken[]
      {

        new(@"^#", lookbehind: false, greedy: false),
      },
      ["punctuation"] = new GrammarToken[]
      {

        new(@"##|\\(?=[\r\n])", lookbehind: false, greedy: false),
      },
      ["expression"] = new GrammarToken[]
      {

        new(@"\S[\s\S]*", lookbehind: false, greedy: false, inside: new Grammar
  {
      ["comment"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["char"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["macro"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["module"] = new GrammarToken[]
      {

        new(@"(\b(?:import|module)\s+)(?:""(?:\\(?:\r\n|[\s\S])|[^""\\\r\n])*""|<[^<>\r\n]*>|\b(?!\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b)\w+(?:\s*\.\s*\w+)*\b(?:\s*:\s*\b(?!\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b)\w+(?:\s*\.\s*\w+)*\b)?|:\s*\b(?!\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b)\w+(?:\s*\.\s*\w+)*\b)", lookbehind: true, greedy: true, inside: new Grammar
  {
      ["string"] = new GrammarToken[]
      {

        new(@"^[<""][\s\S]+", lookbehind: false, greedy: false),
      },
      ["operator"] = new GrammarToken[]
      {

        new(@":", lookbehind: false, greedy: false),
      },
      ["punctuation"] = new GrammarToken[]
      {

        new(@"\.", lookbehind: false, greedy: false),
      },
  }),
      },
      ["raw-string"] = new GrammarToken[]
      {

        new(@"R""([^()\\ ]{0,16})\([\s\S]*?\)\1""", lookbehind: false, greedy: true, alias: new []{"string" }),
      },
      ["string"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["class-name"] = new GrammarToken[]
      {

        new(@"(\b(?:class|concept|enum|struct|typename)\s+)(?!\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b)\w+", lookbehind: true, greedy: false),
        new(@"\b[A-Z]\w*(?=\s*::\s*\w+\s*\()", lookbehind: false, greedy: false),
        new(new Regex(@"\b[A-Z_]\w*(?=\s*::\s*~\w+\s*\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
        new(@"\b\w+(?=\s*<(?:[^<>]|<(?:[^<>]|<[^<>]*>)*>)*>\s*::\s*\w+\s*\()", lookbehind: false, greedy: false),
      },
      ["generic-function"] = new GrammarToken[]
      {

        new(new Regex(@"\b(?!operator\b)[a-z_]\w*\s*<(?:[^<>]|<[^<>]*>)*>(?=\s*\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false, inside: new Grammar
  {
      ["function"] = new GrammarToken[]
      {

        new(@"^\w+", lookbehind: false, greedy: false),
      },
      ["generic"] = new GrammarToken[]
      {

        new(@"<[\s\S]+", lookbehind: false, greedy: false, alias: new []{"class-name" }, inside: null! /* see below */),
      },
  }),
      },
      ["keyword"] = new GrammarToken[]
      {

        new(@"\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b", lookbehind: false, greedy: false),
      },
      ["constant"] = new GrammarToken[]
      {

        new(@"\b(?:EOF|NULL|SEEK_CUR|SEEK_END|SEEK_SET|__DATE__|__FILE__|__LINE__|__TIMESTAMP__|__TIME__|__func__|stderr|stdin|stdout)\b", lookbehind: false, greedy: false),
      },
      ["function"] = new GrammarToken[]
      {

        new(new Regex(@"\b[a-z_]\w*(?=\s*\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
      },
      ["number"] = new GrammarToken[]
      {

        new(new Regex(@"(?:\b0b[01']+|\b0x(?:[\da-f']+(?:\.[\da-f']*)?|\.[\da-f']+)(?:p[+-]?[\d']+)?|(?:\b[\d']+(?:\.[\d']*)?|\B\.[\d']+)(?:e[+-]?[\d']+)?)[ful]{0,4}", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: true),
      },
      ["double-colon"] = new GrammarToken[]
      {

        new(@"::", lookbehind: false, greedy: false, alias: new []{"punctuation" }),
      },
      ["operator"] = new GrammarToken[]
      {

        new(@">>=?|<<=?|->|--|\+\+|&&|\|\||[?:~]|<=>|[-+*/%&|^!=<>]=?|\b(?:and|and_eq|bitand|bitor|not|not_eq|or|or_eq|xor|xor_eq)\b", lookbehind: false, greedy: false),
      },
      ["punctuation"] = new GrammarToken[]
      {

        new(@"[{}[\];(),.:]", lookbehind: false, greedy: false),
      },
      ["boolean"] = new GrammarToken[]
      {

        new(@"\b(?:false|true)\b", lookbehind: false, greedy: false),
      },
  }),
      },
  }),
      },
      ["module"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["raw-string"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["string"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["generic-function"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["keyword"] = new GrammarToken[]
      {

        new(@"\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b", lookbehind: false, greedy: false),
      },
      ["constant"] = new GrammarToken[]
      {

        new(@"\b(?:EOF|NULL|SEEK_CUR|SEEK_END|SEEK_SET|__DATE__|__FILE__|__LINE__|__TIMESTAMP__|__TIME__|__func__|stderr|stdin|stdout)\b", lookbehind: false, greedy: false),
      },
      ["function"] = new GrammarToken[]
      {

        new(new Regex(@"\b[a-z_]\w*(?=\s*\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
      },
      ["number"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["class-name"] = new GrammarToken[]
      {

        new(new Regex(@"\b[a-z_]\w*\b(?!\s*::)", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
      },
      ["double-colon"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["operator"] = new GrammarToken[]
      {

        new(@">>=?|<<=?|->|--|\+\+|&&|\|\||[?:~]|<=>|[-+*/%&|^!=<>]=?|\b(?:and|and_eq|bitand|bitor|not|not_eq|or|or_eq|xor|xor_eq)\b", lookbehind: false, greedy: false),
      },
      ["punctuation"] = new GrammarToken[]
      {

        new(@"[{}[\];(),.:]", lookbehind: false, greedy: false),
      },
      ["boolean"] = new GrammarToken[]
      {

        new(@"\b(?:false|true)\b", lookbehind: false, greedy: false),
      },
  }),
        };
        grammar["class-name"] = new GrammarToken[]
        {

        new(@"(\b(?:class|concept|enum|struct|typename)\s+)(?!\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b)\w+", lookbehind: true, greedy: false),
        new(@"\b[A-Z]\w*(?=\s*::\s*\w+\s*\()", lookbehind: false, greedy: false),
        new(new Regex(@"\b[A-Z_]\w*(?=\s*::\s*~\w+\s*\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
        new(@"\b\w+(?=\s*<(?:[^<>]|<(?:[^<>]|<[^<>]*>)*>)*>\s*::\s*\w+\s*\()", lookbehind: false, greedy: false),
        };
        grammar["generic-function"] = new GrammarToken[]
        {

        new(new Regex(@"\b(?!operator\b)[a-z_]\w*\s*<(?:[^<>]|<[^<>]*>)*>(?=\s*\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false, inside: new Grammar
  {
      ["function"] = new GrammarToken[]
      {

        new(@"^\w+", lookbehind: false, greedy: false),
      },
      ["generic"] = new GrammarToken[]
      {

        new(@"<[\s\S]+", lookbehind: false, greedy: false, alias: new []{"class-name" }, inside: null! /* see below */),
      },
  }),
        };
        grammar["type-opencl-host"] = new GrammarToken[]
        {

        new(@"\b(?:cl_(?:GLenum|GLint|GLuin|addressing_mode|bitfield|bool|buffer_create_type|build_status|channel_(?:order|type)|(?:u?(?:char|int|long|short)|double|float)(?:2|3|4|8|16)?|command_(?:queue(?:_info|_properties)?|type)|context(?:_info|_properties)?|device_(?:exec_capabilities|fp_config|id|info|local_mem_type|mem_cache_type|type)|(?:event|sampler)(?:_info)?|filter_mode|half|image_info|kernel(?:_info|_work_group_info)?|map_flags|mem(?:_flags|_info|_object_type)?|platform_(?:id|info)|profiling_info|program(?:_build_info|_info)?))\b", lookbehind: false, greedy: false, alias: new []{"keyword" }),
        };
        grammar["boolean-opencl-host"] = new GrammarToken[]
        {

        new(@"\bCL_(?:FALSE|TRUE)\b", lookbehind: false, greedy: false, alias: new []{"boolean" }),
        };
        grammar["constant-opencl-host"] = new GrammarToken[]
        {

        new(@"\bCL_(?:A|ABGR|ADDRESS_(?:CLAMP(?:_TO_EDGE)?|MIRRORED_REPEAT|NONE|REPEAT)|ARGB|BGRA|BLOCKING|BUFFER_CREATE_TYPE_REGION|BUILD_(?:ERROR|IN_PROGRESS|NONE|PROGRAM_FAILURE|SUCCESS)|COMMAND_(?:ACQUIRE_GL_OBJECTS|BARRIER|COPY_(?:BUFFER(?:_RECT|_TO_IMAGE)?|IMAGE(?:_TO_BUFFER)?)|FILL_(?:BUFFER|IMAGE)|MAP(?:_BUFFER|_IMAGE)|MARKER|MIGRATE(?:_SVM)?_MEM_OBJECTS|NATIVE_KERNEL|NDRANGE_KERNEL|READ_(?:BUFFER(?:_RECT)?|IMAGE)|RELEASE_GL_OBJECTS|SVM_(?:FREE|MAP|MEMCPY|MEMFILL|UNMAP)|TASK|UNMAP_MEM_OBJECT|USER|WRITE_(?:BUFFER(?:_RECT)?|IMAGE))|COMPILER_NOT_AVAILABLE|COMPILE_PROGRAM_FAILURE|COMPLETE|CONTEXT_(?:DEVICES|INTEROP_USER_SYNC|NUM_DEVICES|PLATFORM|PROPERTIES|REFERENCE_COUNT)|DEPTH(?:_STENCIL)?|DEVICE_(?:ADDRESS_BITS|AFFINITY_DOMAIN_(?:L[1-4]_CACHE|NEXT_PARTITIONABLE|NUMA)|AVAILABLE|BUILT_IN_KERNELS|COMPILER_AVAILABLE|DOUBLE_FP_CONFIG|ENDIAN_LITTLE|ERROR_CORRECTION_SUPPORT|EXECUTION_CAPABILITIES|EXTENSIONS|GLOBAL_(?:MEM_(?:CACHELINE_SIZE|CACHE_SIZE|CACHE_TYPE|SIZE)|VARIABLE_PREFERRED_TOTAL_SIZE)|HOST_UNIFIED_MEMORY|IL_VERSION|IMAGE(?:2D_MAX_(?:HEIGHT|WIDTH)|3D_MAX_(?:DEPTH|HEIGHT|WIDTH)|_BASE_ADDRESS_ALIGNMENT|_MAX_ARRAY_SIZE|_MAX_BUFFER_SIZE|_PITCH_ALIGNMENT|_SUPPORT)|LINKER_AVAILABLE|LOCAL_MEM_SIZE|LOCAL_MEM_TYPE|MAX_(?:CLOCK_FREQUENCY|COMPUTE_UNITS|CONSTANT_ARGS|CONSTANT_BUFFER_SIZE|GLOBAL_VARIABLE_SIZE|MEM_ALLOC_SIZE|NUM_SUB_GROUPS|ON_DEVICE_(?:EVENTS|QUEUES)|PARAMETER_SIZE|PIPE_ARGS|READ_IMAGE_ARGS|READ_WRITE_IMAGE_ARGS|SAMPLERS|WORK_GROUP_SIZE|WORK_ITEM_DIMENSIONS|WORK_ITEM_SIZES|WRITE_IMAGE_ARGS)|MEM_BASE_ADDR_ALIGN|MIN_DATA_TYPE_ALIGN_SIZE|NAME|NATIVE_VECTOR_WIDTH_(?:CHAR|DOUBLE|FLOAT|HALF|INT|LONG|SHORT)|NOT_(?:AVAILABLE|FOUND)|OPENCL_C_VERSION|PARENT_DEVICE|PARTITION_(?:AFFINITY_DOMAIN|BY_AFFINITY_DOMAIN|BY_COUNTS|BY_COUNTS_LIST_END|EQUALLY|FAILED|MAX_SUB_DEVICES|PROPERTIES|TYPE)|PIPE_MAX_(?:ACTIVE_RESERVATIONS|PACKET_SIZE)|PLATFORM|PREFERRED_(?:GLOBAL_ATOMIC_ALIGNMENT|INTEROP_USER_SYNC|LOCAL_ATOMIC_ALIGNMENT|PLATFORM_ATOMIC_ALIGNMENT|VECTOR_WIDTH_(?:CHAR|DOUBLE|FLOAT|HALF|INT|LONG|SHORT))|PRINTF_BUFFER_SIZE|PROFILE|PROFILING_TIMER_RESOLUTION|QUEUE_(?:ON_(?:DEVICE_(?:MAX_SIZE|PREFERRED_SIZE|PROPERTIES)|HOST_PROPERTIES)|PROPERTIES)|REFERENCE_COUNT|SINGLE_FP_CONFIG|SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS|SVM_(?:ATOMICS|CAPABILITIES|COARSE_GRAIN_BUFFER|FINE_GRAIN_BUFFER|FINE_GRAIN_SYSTEM)|TYPE(?:_ACCELERATOR|_ALL|_CPU|_CUSTOM|_DEFAULT|_GPU)?|VENDOR(?:_ID)?|VERSION)|DRIVER_VERSION|EVENT_(?:COMMAND_(?:EXECUTION_STATUS|QUEUE|TYPE)|CONTEXT|REFERENCE_COUNT)|EXEC_(?:KERNEL|NATIVE_KERNEL|STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST)|FILTER_(?:LINEAR|NEAREST)|FLOAT|FP_(?:CORRECTLY_ROUNDED_DIVIDE_SQRT|DENORM|FMA|INF_NAN|ROUND_TO_INF|ROUND_TO_NEAREST|ROUND_TO_ZERO|SOFT_FLOAT)|GLOBAL|HALF_FLOAT|IMAGE_(?:ARRAY_SIZE|BUFFER|DEPTH|ELEMENT_SIZE|FORMAT|FORMAT_MISMATCH|FORMAT_NOT_SUPPORTED|HEIGHT|NUM_MIP_LEVELS|NUM_SAMPLES|ROW_PITCH|SLICE_PITCH|WIDTH)|INTENSITY|INVALID_(?:ARG_INDEX|ARG_SIZE|ARG_VALUE|BINARY|BUFFER_SIZE|BUILD_OPTIONS|COMMAND_QUEUE|COMPILER_OPTIONS|CONTEXT|DEVICE|DEVICE_PARTITION_COUNT|DEVICE_QUEUE|DEVICE_TYPE|EVENT|EVENT_WAIT_LIST|GLOBAL_OFFSET|GLOBAL_WORK_SIZE|GL_OBJECT|HOST_PTR|IMAGE_DESCRIPTOR|IMAGE_FORMAT_DESCRIPTOR|IMAGE_SIZE|KERNEL|KERNEL_ARGS|KERNEL_DEFINITION|KERNEL_NAME|LINKER_OPTIONS|MEM_OBJECT|MIP_LEVEL|OPERATION|PIPE_SIZE|PLATFORM|PROGRAM|PROGRAM_EXECUTABLE|PROPERTY|QUEUE_PROPERTIES|SAMPLER|VALUE|WORK_DIMENSION|WORK_GROUP_SIZE|WORK_ITEM_SIZE)|KERNEL_(?:ARG_(?:ACCESS_(?:NONE|QUALIFIER|READ_ONLY|READ_WRITE|WRITE_ONLY)|ADDRESS_(?:CONSTANT|GLOBAL|LOCAL|PRIVATE|QUALIFIER)|INFO_NOT_AVAILABLE|NAME|TYPE_(?:CONST|NAME|NONE|PIPE|QUALIFIER|RESTRICT|VOLATILE))|ATTRIBUTES|COMPILE_NUM_SUB_GROUPS|COMPILE_WORK_GROUP_SIZE|CONTEXT|EXEC_INFO_SVM_FINE_GRAIN_SYSTEM|EXEC_INFO_SVM_PTRS|FUNCTION_NAME|GLOBAL_WORK_SIZE|LOCAL_MEM_SIZE|LOCAL_SIZE_FOR_SUB_GROUP_COUNT|MAX_NUM_SUB_GROUPS|MAX_SUB_GROUP_SIZE_FOR_NDRANGE|NUM_ARGS|PREFERRED_WORK_GROUP_SIZE_MULTIPLE|PRIVATE_MEM_SIZE|PROGRAM|REFERENCE_COUNT|SUB_GROUP_COUNT_FOR_NDRANGE|WORK_GROUP_SIZE)|LINKER_NOT_AVAILABLE|LINK_PROGRAM_FAILURE|LOCAL|LUMINANCE|MAP_(?:FAILURE|READ|WRITE|WRITE_INVALIDATE_REGION)|MEM_(?:ALLOC_HOST_PTR|ASSOCIATED_MEMOBJECT|CONTEXT|COPY_HOST_PTR|COPY_OVERLAP|FLAGS|HOST_NO_ACCESS|HOST_PTR|HOST_READ_ONLY|HOST_WRITE_ONLY|KERNEL_READ_AND_WRITE|MAP_COUNT|OBJECT_(?:ALLOCATION_FAILURE|BUFFER|IMAGE1D|IMAGE1D_ARRAY|IMAGE1D_BUFFER|IMAGE2D|IMAGE2D_ARRAY|IMAGE3D|PIPE)|OFFSET|READ_ONLY|READ_WRITE|REFERENCE_COUNT|SIZE|SVM_ATOMICS|SVM_FINE_GRAIN_BUFFER|TYPE|USES_SVM_POINTER|USE_HOST_PTR|WRITE_ONLY)|MIGRATE_MEM_OBJECT_(?:CONTENT_UNDEFINED|HOST)|MISALIGNED_SUB_BUFFER_OFFSET|NONE|NON_BLOCKING|OUT_OF_(?:HOST_MEMORY|RESOURCES)|PIPE_(?:MAX_PACKETS|PACKET_SIZE)|PLATFORM_(?:EXTENSIONS|HOST_TIMER_RESOLUTION|NAME|PROFILE|VENDOR|VERSION)|PROFILING_(?:COMMAND_(?:COMPLETE|END|QUEUED|START|SUBMIT)|INFO_NOT_AVAILABLE)|PROGRAM_(?:BINARIES|BINARY_SIZES|BINARY_TYPE(?:_COMPILED_OBJECT|_EXECUTABLE|_LIBRARY|_NONE)?|BUILD_(?:GLOBAL_VARIABLE_TOTAL_SIZE|LOG|OPTIONS|STATUS)|CONTEXT|DEVICES|IL|KERNEL_NAMES|NUM_DEVICES|NUM_KERNELS|REFERENCE_COUNT|SOURCE)|QUEUED|QUEUE_(?:CONTEXT|DEVICE|DEVICE_DEFAULT|ON_DEVICE|ON_DEVICE_DEFAULT|OUT_OF_ORDER_EXEC_MODE_ENABLE|PROFILING_ENABLE|PROPERTIES|REFERENCE_COUNT|SIZE)|R|RA|READ_(?:ONLY|WRITE)_CACHE|RG|RGB|RGBA|RGBx|RGx|RUNNING|Rx|SAMPLER_(?:ADDRESSING_MODE|CONTEXT|FILTER_MODE|LOD_MAX|LOD_MIN|MIP_FILTER_MODE|NORMALIZED_COORDS|REFERENCE_COUNT)|(?:UN)?SIGNED_INT(?:8|16|32)|SNORM_INT(?:8|16)|SUBMITTED|SUCCESS|UNORM_INT(?:8|16|24|_101010|_101010_2)|UNORM_SHORT_(?:555|565)|VERSION_(?:1_0|1_1|1_2|2_0|2_1)|sBGRA|sRGB|sRGBA|sRGBx)\b", lookbehind: false, greedy: false, alias: new []{"constant" }),
        };
        grammar["function-opencl-host"] = new GrammarToken[]
        {

        new(@"\bcl(?:BuildProgram|CloneKernel|CompileProgram|Create(?:Buffer|CommandQueue(?:WithProperties)?|Context|ContextFromType|Image|Image2D|Image3D|Kernel|KernelsInProgram|Pipe|ProgramWith(?:Binary|BuiltInKernels|IL|Source)|Sampler|SamplerWithProperties|SubBuffer|SubDevices|UserEvent)|Enqueue(?:(?:Barrier|Marker)(?:WithWaitList)?|Copy(?:Buffer(?:Rect|ToImage)?|Image(?:ToBuffer)?)|(?:Fill|Map)(?:Buffer|Image)|MigrateMemObjects|NDRangeKernel|NativeKernel|(?:Read|Write)(?:Buffer(?:Rect)?|Image)|SVM(?:Free|Map|MemFill|Memcpy|MigrateMem|Unmap)|Task|UnmapMemObject|WaitForEvents)|Finish|Flush|Get(?:CommandQueueInfo|ContextInfo|Device(?:AndHostTimer|IDs|Info)|Event(?:Profiling)?Info|ExtensionFunctionAddress(?:ForPlatform)?|HostTimer|ImageInfo|Kernel(?:ArgInfo|Info|SubGroupInfo|WorkGroupInfo)|MemObjectInfo|PipeInfo|Platform(?:IDs|Info)|Program(?:Build)?Info|SamplerInfo|SupportedImageFormats)|LinkProgram|(?:Release|Retain)(?:CommandQueue|Context|Device|Event|Kernel|MemObject|Program|Sampler)|SVM(?:Alloc|Free)|Set(?:CommandQueueProperty|DefaultDeviceCommandQueue|EventCallback|Kernel|Kernel(?:Arg(?:SVMPointer)?|ExecInfo)|MemObjectDestructorCallback|UserEventStatus)|Unload(?:Platform)?Compiler|WaitForEvents)\b", lookbehind: false, greedy: false, alias: new []{"function" }),
        };
        grammar["type-opencl-host-cpp"] = new GrammarToken[]
        {

        new(@"\b(?:Buffer|BufferGL|BufferRenderGL|CommandQueue|Context|Device|DeviceCommandQueue|EnqueueArgs|Event|Image|Image1D|Image1DArray|Image1DBuffer|Image2D|Image2DArray|Image2DGL|Image3D|Image3DGL|ImageFormat|ImageGL|Kernel|KernelFunctor|LocalSpaceArg|Memory|NDRange|Pipe|Platform|Program|SVMAllocator|SVMTraitAtomic|SVMTraitCoarse|SVMTraitFine|SVMTraitReadOnly|SVMTraitReadWrite|SVMTraitWriteOnly|Sampler|UserEvent)\b", lookbehind: false, greedy: false, alias: new []{"keyword" }),
        };
        grammar["keyword"] = new GrammarToken[]
        {

        new(@"\b(?:alignas|alignof|asm|auto|bool|break|case|catch|char|char16_t|char32_t|char8_t|class|co_await|co_return|co_yield|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|final|float|for|friend|goto|if|import|inline|int|int16_t|int32_t|int64_t|int8_t|long|module|mutable|namespace|new|noexcept|nullptr|operator|override|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|try|typedef|typeid|typename|uint16_t|uint32_t|uint64_t|uint8_t|union|unsigned|using|virtual|void|volatile|wchar_t|while)\b", lookbehind: false, greedy: false),
        };
        grammar["constant"] = new GrammarToken[]
        {

        new(@"\b(?:EOF|NULL|SEEK_CUR|SEEK_END|SEEK_SET|__DATE__|__FILE__|__LINE__|__TIMESTAMP__|__TIME__|__func__|stderr|stdin|stdout)\b", lookbehind: false, greedy: false),
        };
        grammar["function"] = new GrammarToken[]
        {

        new(new Regex(@"\b[a-z_]\w*(?=\s*\()", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
        };
        grammar["number"] = new GrammarToken[]
        {

        new(new Regex(@"(?:\b0b[01']+|\b0x(?:[\da-f']+(?:\.[\da-f']*)?|\.[\da-f']+)(?:p[+-]?[\d']+)?|(?:\b[\d']+(?:\.[\d']*)?|\B\.[\d']+)(?:e[+-]?[\d']+)?)[ful]{0,4}", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: true),
        };
        grammar["double-colon"] = new GrammarToken[]
        {

        new(@"::", lookbehind: false, greedy: false, alias: new []{"punctuation" }),
        };
        grammar["operator"] = new GrammarToken[]
        {

        new(@">>=?|<<=?|->|--|\+\+|&&|\|\||[?:~]|<=>|[-+*/%&|^!=<>]=?|\b(?:and|and_eq|bitand|bitor|not|not_eq|or|or_eq|xor|xor_eq)\b", lookbehind: false, greedy: false),
        };
        grammar["punctuation"] = new GrammarToken[]
        {

        new(@"[{}[\];(),.:]", lookbehind: false, greedy: false),
        };
        grammar["boolean"] = new GrammarToken[]
        {

        new(@"\b(?:false|true)\b", lookbehind: false, greedy: false),
        };
        grammar["macro"][0].Inside!["char"][0] = grammar["char"][0];
        grammar["macro"][0].Inside!["comment"][0] = grammar["comment"][0];
        grammar["macro"][0].Inside!["expression"][0].Inside = grammar;
        grammar["string"][0] = grammar["macro"][0].Inside!["string"][1];
        grammar["base-clause"][0].Inside!["macro"][0].Inside!["char"][0] = grammar["base-clause"][0].Inside!["char"][0];
        grammar["base-clause"][0].Inside!["macro"][0].Inside!["comment"][0] = grammar["base-clause"][0].Inside!["comment"][0];
        grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["comment"][0] = grammar["base-clause"][0].Inside!["comment"][0];
        grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["char"][0] = grammar["base-clause"][0].Inside!["char"][0];
        grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["macro"][0] = grammar["base-clause"][0].Inside!["macro"][0];
        grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["string"][0] = grammar["base-clause"][0].Inside!["macro"][0].Inside!["string"][1];
        grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["generic-function"][0].Inside!["generic"][0].Inside = grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!;
        grammar["base-clause"][0].Inside!["module"][0] = grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["module"][0];
        grammar["base-clause"][0].Inside!["raw-string"][0] = grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["raw-string"][0];
        grammar["base-clause"][0].Inside!["string"][0] = grammar["base-clause"][0].Inside!["macro"][0].Inside!["string"][1];
        grammar["base-clause"][0].Inside!["generic-function"][0] = grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["generic-function"][0];
        grammar["base-clause"][0].Inside!["number"][0] = grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["number"][0];
        grammar["base-clause"][0].Inside!["double-colon"][0] = grammar["base-clause"][0].Inside!["macro"][0].Inside!["expression"][0].Inside!["double-colon"][0];
        grammar["generic-function"][0].Inside!["generic"][0].Inside = grammar;

        return grammar;
    }
}
