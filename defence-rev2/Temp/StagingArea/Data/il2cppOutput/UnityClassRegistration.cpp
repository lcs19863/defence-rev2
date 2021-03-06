template <typename T> void RegisterClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_CloudWebServices();
	RegisterModule_CloudWebServices();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_PerformanceReporting();
	RegisterModule_PerformanceReporting();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityAnalytics();
	RegisterModule_UnityAnalytics();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_TLS();
	RegisterModule_TLS();

	void RegisterModule_WebGL();
	RegisterModule_WebGL();

}

class EditorExtension; template <> void RegisterClass<EditorExtension>(const char*);
namespace Unity { class Component; } template <> void RegisterClass<Unity::Component>(const char*);
class Behaviour; template <> void RegisterClass<Behaviour>(const char*);
class Animation; 
class Animator; template <> void RegisterClass<Animator>(const char*);
class AudioBehaviour; template <> void RegisterClass<AudioBehaviour>(const char*);
class AudioListener; template <> void RegisterClass<AudioListener>(const char*);
class AudioSource; template <> void RegisterClass<AudioSource>(const char*);
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterClass<Camera>(const char*);
namespace UI { class Canvas; } template <> void RegisterClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterClass<UI::CanvasGroup>(const char*);
namespace Unity { class Cloth; } 
class Collider2D; template <> void RegisterClass<Collider2D>(const char*);
class BoxCollider2D; template <> void RegisterClass<BoxCollider2D>(const char*);
class CapsuleCollider2D; template <> void RegisterClass<CapsuleCollider2D>(const char*);
class CircleCollider2D; template <> void RegisterClass<CircleCollider2D>(const char*);
class CompositeCollider2D; 
class EdgeCollider2D; 
class PolygonCollider2D; 
class TilemapCollider2D; 
class ConstantForce; 
class Effector2D; template <> void RegisterClass<Effector2D>(const char*);
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; template <> void RegisterClass<PointEffector2D>(const char*);
class SurfaceEffector2D; 
class FlareLayer; template <> void RegisterClass<FlareLayer>(const char*);
class GUIElement; template <> void RegisterClass<GUIElement>(const char*);
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterClass<GUILayer>(const char*);
class GridLayout; 
class Grid; 
class Tilemap; 
class Halo; 
class HaloLayer; 
class IConstraint; 
class AimConstraint; 
class ParentConstraint; 
class PositionConstraint; 
class RotationConstraint; 
class ScaleConstraint; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; 
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterClass<MonoBehaviour>(const char*);
class NavMeshAgent; 
class NavMeshObstacle; 
class OffMeshLink; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; 
class Projector; 
class ReflectionProbe; 
class Skybox; 
class SortingGroup; 
class Terrain; 
class VideoPlayer; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterClass<UI::CanvasRenderer>(const char*);
class Collider; 
class BoxCollider; 
class CapsuleCollider; 
class CharacterController; 
class MeshCollider; 
class SphereCollider; 
class TerrainCollider; 
class WheelCollider; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterClass<MeshFilter>(const char*);
class OcclusionArea; 
class OcclusionPortal; 
class ParticleAnimator; 
class ParticleEmitter; 
class EllipsoidParticleEmitter; 
class MeshParticleEmitter; 
class ParticleSystem; 
class Renderer; template <> void RegisterClass<Renderer>(const char*);
class BillboardRenderer; 
class LineRenderer; 
class MeshRenderer; template <> void RegisterClass<MeshRenderer>(const char*);
class ParticleRenderer; 
class ParticleSystemRenderer; 
class SkinnedMeshRenderer; 
class SpriteMask; 
class SpriteRenderer; template <> void RegisterClass<SpriteRenderer>(const char*);
class SpriteShapeRenderer; 
class TilemapRenderer; 
class TrailRenderer; 
class Rigidbody; 
class Rigidbody2D; template <> void RegisterClass<Rigidbody2D>(const char*);
namespace TextRenderingPrivate { class TextMesh; } 
class Transform; template <> void RegisterClass<Transform>(const char*);
namespace UI { class RectTransform; } template <> void RegisterClass<UI::RectTransform>(const char*);
class Tree; 
class WorldParticleCollider; 
class GameObject; template <> void RegisterClass<GameObject>(const char*);
class NamedObject; template <> void RegisterClass<NamedObject>(const char*);
class AssetBundle; 
class AssetBundleManifest; 
class ScriptedImporter; 
class AssetImporterLog; 
class AudioMixer; 
class AudioMixerController; 
class AudioMixerGroup; 
class AudioMixerGroupController; 
class AudioMixerSnapshot; 
class AudioMixerSnapshotController; 
class Avatar; 
class AvatarMask; 
class BillboardAsset; 
class ComputeShader; 
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterClass<TextRendering::Font>(const char*);
class GameObjectRecorder; 
class LightProbes; 
class Material; template <> void RegisterClass<Material>(const char*);
class ProceduralMaterial; 
class Mesh; template <> void RegisterClass<Mesh>(const char*);
class Motion; template <> void RegisterClass<Motion>(const char*);
class AnimationClip; template <> void RegisterClass<AnimationClip>(const char*);
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterClass<PreloadData>(const char*);
class RuntimeAnimatorController; template <> void RegisterClass<RuntimeAnimatorController>(const char*);
class AnimatorController; template <> void RegisterClass<AnimatorController>(const char*);
class AnimatorOverrideController; template <> void RegisterClass<AnimatorOverrideController>(const char*);
class SampleClip; template <> void RegisterClass<SampleClip>(const char*);
class AudioClip; template <> void RegisterClass<AudioClip>(const char*);
class Shader; template <> void RegisterClass<Shader>(const char*);
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterClass<Sprite>(const char*);
class SpriteAtlas; 
class SubstanceArchive; 
class TerrainData; 
class TextAsset; template <> void RegisterClass<TextAsset>(const char*);
class CGProgram; 
class MonoScript; template <> void RegisterClass<MonoScript>(const char*);
class Texture; template <> void RegisterClass<Texture>(const char*);
class BaseVideoTexture; 
class WebCamTexture; 
class CubemapArray; 
class LowerResBlitTexture; template <> void RegisterClass<LowerResBlitTexture>(const char*);
class ProceduralTexture; 
class RenderTexture; template <> void RegisterClass<RenderTexture>(const char*);
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterClass<Texture2D>(const char*);
class Cubemap; template <> void RegisterClass<Cubemap>(const char*);
class Texture2DArray; template <> void RegisterClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterClass<Texture3D>(const char*);
class VideoClip; 
class GameManager; template <> void RegisterClass<GameManager>(const char*);
class GlobalGameManager; template <> void RegisterClass<GlobalGameManager>(const char*);
class AudioManager; template <> void RegisterClass<AudioManager>(const char*);
class BuildSettings; template <> void RegisterClass<BuildSettings>(const char*);
class CloudWebServicesManager; template <> void RegisterClass<CloudWebServicesManager>(const char*);
class CrashReportManager; 
class DelayedCallManager; template <> void RegisterClass<DelayedCallManager>(const char*);
class GraphicsSettings; template <> void RegisterClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterClass<InputManager>(const char*);
class MonoManager; template <> void RegisterClass<MonoManager>(const char*);
class NavMeshProjectSettings; 
class PerformanceReportingManager; template <> void RegisterClass<PerformanceReportingManager>(const char*);
class Physics2DSettings; template <> void RegisterClass<Physics2DSettings>(const char*);
class PhysicsManager; 
class PlayerSettings; template <> void RegisterClass<PlayerSettings>(const char*);
class QualitySettings; template <> void RegisterClass<QualitySettings>(const char*);
class ResourceManager; template <> void RegisterClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterClass<RuntimeInitializeOnLoadManager>(const char*);
class ScriptMapper; template <> void RegisterClass<ScriptMapper>(const char*);
class TagManager; template <> void RegisterClass<TagManager>(const char*);
class TimeManager; template <> void RegisterClass<TimeManager>(const char*);
class UnityAnalyticsManager; template <> void RegisterClass<UnityAnalyticsManager>(const char*);
class UnityConnectSettings; template <> void RegisterClass<UnityConnectSettings>(const char*);
class LevelGameManager; template <> void RegisterClass<LevelGameManager>(const char*);
class LightmapSettings; template <> void RegisterClass<LightmapSettings>(const char*);
class NavMeshSettings; 
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterClass<RenderSettings>(const char*);
class RenderPassAttachment; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 77 non stripped classes
	//0. Camera
	RegisterClass<Camera>("Core");
	//1. Behaviour
	RegisterClass<Behaviour>("Core");
	//2. Unity::Component
	RegisterClass<Unity::Component>("Core");
	//3. EditorExtension
	RegisterClass<EditorExtension>("Core");
	//4. Renderer
	RegisterClass<Renderer>("Core");
	//5. Shader
	RegisterClass<Shader>("Core");
	//6. NamedObject
	RegisterClass<NamedObject>("Core");
	//7. Mesh
	RegisterClass<Mesh>("Core");
	//8. MonoBehaviour
	RegisterClass<MonoBehaviour>("Core");
	//9. Material
	RegisterClass<Material>("Core");
	//10. Texture
	RegisterClass<Texture>("Core");
	//11. Texture2D
	RegisterClass<Texture2D>("Core");
	//12. RenderTexture
	RegisterClass<RenderTexture>("Core");
	//13. Sprite
	RegisterClass<Sprite>("Core");
	//14. GameObject
	RegisterClass<GameObject>("Core");
	//15. GUIElement
	RegisterClass<GUIElement>("Core");
	//16. GUILayer
	RegisterClass<GUILayer>("Core");
	//17. SpriteRenderer
	RegisterClass<SpriteRenderer>("Core");
	//18. Transform
	RegisterClass<Transform>("Core");
	//19. UI::RectTransform
	RegisterClass<UI::RectTransform>("Core");
	//20. Animator
	RegisterClass<Animator>("Animation");
	//21. AnimatorOverrideController
	RegisterClass<AnimatorOverrideController>("Animation");
	//22. RuntimeAnimatorController
	RegisterClass<RuntimeAnimatorController>("Animation");
	//23. Rigidbody2D
	RegisterClass<Rigidbody2D>("Physics2D");
	//24. Collider2D
	RegisterClass<Collider2D>("Physics2D");
	//25. AudioClip
	RegisterClass<AudioClip>("Audio");
	//26. SampleClip
	RegisterClass<SampleClip>("Audio");
	//27. AudioListener
	RegisterClass<AudioListener>("Audio");
	//28. AudioBehaviour
	RegisterClass<AudioBehaviour>("Audio");
	//29. AudioSource
	RegisterClass<AudioSource>("Audio");
	//30. TextRendering::Font
	RegisterClass<TextRendering::Font>("TextRendering");
	//31. UI::Canvas
	RegisterClass<UI::Canvas>("UI");
	//32. UI::CanvasGroup
	RegisterClass<UI::CanvasGroup>("UI");
	//33. UI::CanvasRenderer
	RegisterClass<UI::CanvasRenderer>("UI");
	//34. BoxCollider2D
	RegisterClass<BoxCollider2D>("Physics2D");
	//35. PreloadData
	RegisterClass<PreloadData>("Core");
	//36. Cubemap
	RegisterClass<Cubemap>("Core");
	//37. Texture3D
	RegisterClass<Texture3D>("Core");
	//38. Texture2DArray
	RegisterClass<Texture2DArray>("Core");
	//39. MeshFilter
	RegisterClass<MeshFilter>("Core");
	//40. MeshRenderer
	RegisterClass<MeshRenderer>("Core");
	//41. LowerResBlitTexture
	RegisterClass<LowerResBlitTexture>("Core");
	//42. GameManager
	RegisterClass<GameManager>("Core");
	//43. GlobalGameManager
	RegisterClass<GlobalGameManager>("Core");
	//44. TagManager
	RegisterClass<TagManager>("Core");
	//45. GraphicsSettings
	RegisterClass<GraphicsSettings>("Core");
	//46. DelayedCallManager
	RegisterClass<DelayedCallManager>("Core");
	//47. QualitySettings
	RegisterClass<QualitySettings>("Core");
	//48. TimeManager
	RegisterClass<TimeManager>("Core");
	//49. InputManager
	RegisterClass<InputManager>("Core");
	//50. BuildSettings
	RegisterClass<BuildSettings>("Core");
	//51. MonoScript
	RegisterClass<MonoScript>("Core");
	//52. TextAsset
	RegisterClass<TextAsset>("Core");
	//53. PlayerSettings
	RegisterClass<PlayerSettings>("Core");
	//54. RuntimeInitializeOnLoadManager
	RegisterClass<RuntimeInitializeOnLoadManager>("Core");
	//55. ResourceManager
	RegisterClass<ResourceManager>("Core");
	//56. ScriptMapper
	RegisterClass<ScriptMapper>("Core");
	//57. MonoManager
	RegisterClass<MonoManager>("Core");
	//58. AudioManager
	RegisterClass<AudioManager>("Audio");
	//59. MasterServerInterface
	//Skipping MasterServerInterface
	//60. CloudWebServicesManager
	RegisterClass<CloudWebServicesManager>("CloudWebServices");
	//61. PerformanceReportingManager
	RegisterClass<PerformanceReportingManager>("PerformanceReporting");
	//62. Physics2DSettings
	RegisterClass<Physics2DSettings>("Physics2D");
	//63. UnityAnalyticsManager
	RegisterClass<UnityAnalyticsManager>("UnityAnalytics");
	//64. UnityConnectSettings
	RegisterClass<UnityConnectSettings>("UnityConnect");
	//65. LevelGameManager
	RegisterClass<LevelGameManager>("Core");
	//66. FlareLayer
	RegisterClass<FlareLayer>("Core");
	//67. RenderSettings
	RegisterClass<RenderSettings>("Core");
	//68. LightmapSettings
	RegisterClass<LightmapSettings>("Core");
	//69. Motion
	RegisterClass<Motion>("Animation");
	//70. AnimationClip
	RegisterClass<AnimationClip>("Animation");
	//71. AnimatorController
	RegisterClass<AnimatorController>("Animation");
	//72. Effector2D
	RegisterClass<Effector2D>("Physics2D");
	//73. CircleCollider2D
	RegisterClass<CircleCollider2D>("Physics2D");
	//74. CapsuleCollider2D
	RegisterClass<CapsuleCollider2D>("Physics2D");
	//75. PointEffector2D
	RegisterClass<PointEffector2D>("Physics2D");
	//76. NetworkManager
	//Skipping NetworkManager

}
