using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B8 RID: 184
	public class VolumetricDustParticles : MonoBehaviour
	{
		// Token: 0x06000D9D RID: 3485 RVA: 0x0009C6C4 File Offset: 0x0009A8C4
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricDustParticles()
		{
			Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricDustParticles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr);
			VolumetricDustParticles.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "ClassName");
			VolumetricDustParticles.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "alpha");
			VolumetricDustParticles.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "size");
			VolumetricDustParticles.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "direction");
			VolumetricDustParticles.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "velocity");
			VolumetricDustParticles.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "speed");
			VolumetricDustParticles.NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "density");
			VolumetricDustParticles.NativeFieldInfoPtr_spawnDistanceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "spawnDistanceRange");
			VolumetricDustParticles.NativeFieldInfoPtr_spawnMinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "spawnMinDistance");
			VolumetricDustParticles.NativeFieldInfoPtr_spawnMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "spawnMaxDistance");
			VolumetricDustParticles.NativeFieldInfoPtr_cullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "cullingEnabled");
			VolumetricDustParticles.NativeFieldInfoPtr_cullingMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "cullingMaxDistance");
			VolumetricDustParticles.NativeFieldInfoPtr__isCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "<isCulled>k__BackingField");
			VolumetricDustParticles.NativeFieldInfoPtr_m_AlphaAdditionalRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_AlphaAdditionalRuntime");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Particles");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Renderer");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Material");
			VolumetricDustParticles.NativeFieldInfoPtr_m_GradientCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_GradientCached");
			VolumetricDustParticles.NativeFieldInfoPtr_m_RuntimePropertiesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_RuntimePropertiesDirty");
			VolumetricDustParticles.NativeFieldInfoPtr_ms_NoMainCameraLogged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "ms_NoMainCameraLogged");
			VolumetricDustParticles.NativeFieldInfoPtr_ms_MainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "ms_MainCamera");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Master");
			VolumetricDustParticles.NativeMethodInfoPtr_get_isCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664981);
			VolumetricDustParticles.NativeMethodInfoPtr_set_isCulled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664982);
			VolumetricDustParticles.NativeMethodInfoPtr_get_alphaAdditionalRuntime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664983);
			VolumetricDustParticles.NativeMethodInfoPtr_set_alphaAdditionalRuntime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664984);
			VolumetricDustParticles.NativeMethodInfoPtr_get_particlesAreInstantiated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664985);
			VolumetricDustParticles.NativeMethodInfoPtr_get_particlesCurrentCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664986);
			VolumetricDustParticles.NativeMethodInfoPtr_get_particlesMaxCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664987);
			VolumetricDustParticles.NativeMethodInfoPtr_get_mainCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664988);
			VolumetricDustParticles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664989);
			VolumetricDustParticles.NativeMethodInfoPtr_InstantiateParticleSystem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664990);
			VolumetricDustParticles.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664991);
			VolumetricDustParticles.NativeMethodInfoPtr_SetActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664992);
			VolumetricDustParticles.NativeMethodInfoPtr_SetActiveAndPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664993);
			VolumetricDustParticles.NativeMethodInfoPtr_Play_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664994);
			VolumetricDustParticles.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664995);
			VolumetricDustParticles.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664996);
			VolumetricDustParticles.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664997);
			VolumetricDustParticles.NativeMethodInfoPtr_SetParticleProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664998);
			VolumetricDustParticles.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664999);
			VolumetricDustParticles.NativeMethodInfoPtr_UpdateCulling_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100665000);
			VolumetricDustParticles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100665001);
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0009CA50 File Offset: 0x0009AC50
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x0009CA8C File Offset: 0x0009AC8C
		public unsafe bool isCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_isCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_set_isCulled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x0009CACC File Offset: 0x0009ACCC
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x0009CB08 File Offset: 0x0009AD08
		public unsafe float alphaAdditionalRuntime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_alphaAdditionalRuntime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85033, RefRangeEnd = 85034, XrefRangeStart = 85033, XrefRangeEnd = 85033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_set_alphaAdditionalRuntime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x0009CB48 File Offset: 0x0009AD48
		public unsafe bool particlesAreInstantiated
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85034, XrefRangeEnd = 85038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_particlesAreInstantiated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0009CB84 File Offset: 0x0009AD84
		public unsafe int particlesCurrentCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85038, XrefRangeEnd = 85043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_particlesCurrentCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x0009CBC0 File Offset: 0x0009ADC0
		public unsafe int particlesMaxCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85043, XrefRangeEnd = 85049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_particlesMaxCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0009CBFC File Offset: 0x0009ADFC
		public unsafe Camera mainCamera
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 85076, RefRangeEnd = 85078, XrefRangeStart = 85049, XrefRangeEnd = 85076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_mainCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0009CC3C File Offset: 0x0009AE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85078, XrefRangeEnd = 85086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0009CC70 File Offset: 0x0009AE70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85126, RefRangeEnd = 85127, XrefRangeStart = 85086, XrefRangeEnd = 85126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateParticleSystem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_InstantiateParticleSystem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0009CCA4 File Offset: 0x0009AEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85127, XrefRangeEnd = 85128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0009CCD8 File Offset: 0x0009AED8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85134, RefRangeEnd = 85137, XrefRangeStart = 85128, XrefRangeEnd = 85134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_SetActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0009CD18 File Offset: 0x0009AF18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85145, RefRangeEnd = 85147, XrefRangeStart = 85137, XrefRangeEnd = 85145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveAndPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_SetActiveAndPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0009CD4C File Offset: 0x0009AF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85147, XrefRangeEnd = 85154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_Play_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0009CD80 File Offset: 0x0009AF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85154, XrefRangeEnd = 85155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0009CDB4 File Offset: 0x0009AFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85155, XrefRangeEnd = 85171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0009CDE8 File Offset: 0x0009AFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85171, XrefRangeEnd = 85190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0009CE1C File Offset: 0x0009B01C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85372, RefRangeEnd = 85375, XrefRangeStart = 85190, XrefRangeEnd = 85372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticleProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_SetParticleProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0009CE50 File Offset: 0x0009B050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85375, XrefRangeEnd = 85376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref serializedVersion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0009CE9C File Offset: 0x0009B09C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85413, RefRangeEnd = 85414, XrefRangeStart = 85376, XrefRangeEnd = 85413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_UpdateCulling_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0009CED0 File Offset: 0x0009B0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85414, XrefRangeEnd = 85425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricDustParticles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000088FB File Offset: 0x00006AFB
		public VolumetricDustParticles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0009CF0C File Offset: 0x0009B10C
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x00008904 File Offset: 0x00006B04
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0009CF2C File Offset: 0x0009B12C
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x00008916 File Offset: 0x00006B16
		public unsafe float alpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_alpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_alpha)) = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0009CF54 File Offset: 0x0009B154
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00008931 File Offset: 0x00006B31
		public unsafe float size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0009CF7C File Offset: 0x0009B17C
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x0000894C File Offset: 0x00006B4C
		public unsafe ParticlesDirection direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_direction)) = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0009CFA4 File Offset: 0x0009B1A4
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x00008967 File Offset: 0x00006B67
		public unsafe Vector3 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0009CFCC File Offset: 0x0009B1CC
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x00008982 File Offset: 0x00006B82
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0009CFF4 File Offset: 0x0009B1F4
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x0000899D File Offset: 0x00006B9D
		public unsafe float density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_density);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_density)) = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0009D01C File Offset: 0x0009B21C
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x000089B8 File Offset: 0x00006BB8
		public unsafe MinMaxRangeFloat spawnDistanceRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnDistanceRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnDistanceRange)) = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0009D044 File Offset: 0x0009B244
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x000089D3 File Offset: 0x00006BD3
		public unsafe float spawnMinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMinDistance)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0009D06C File Offset: 0x0009B26C
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x000089EE File Offset: 0x00006BEE
		public unsafe float spawnMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMaxDistance)) = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0009D094 File Offset: 0x0009B294
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x00008A09 File Offset: 0x00006C09
		public unsafe bool cullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingEnabled)) = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x0009D0BC File Offset: 0x0009B2BC
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00008A24 File Offset: 0x00006C24
		public unsafe float cullingMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingMaxDistance)) = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0009D0E4 File Offset: 0x0009B2E4
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00008A3F File Offset: 0x00006C3F
		public unsafe bool _isCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr__isCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr__isCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0009D10C File Offset: 0x0009B30C
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00008A5A File Offset: 0x00006C5A
		public unsafe float m_AlphaAdditionalRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_AlphaAdditionalRuntime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_AlphaAdditionalRuntime)) = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0009D134 File Offset: 0x0009B334
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00008A75 File Offset: 0x00006C75
		public unsafe ParticleSystem m_Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0009D164 File Offset: 0x0009B364
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00008A94 File Offset: 0x00006C94
		public unsafe ParticleSystemRenderer m_Renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystemRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0009D194 File Offset: 0x0009B394
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00008AB3 File Offset: 0x00006CB3
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x00008AD2 File Offset: 0x00006CD2
		public unsafe Gradient m_GradientCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_GradientCached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_GradientCached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0009D1F4 File Offset: 0x0009B3F4
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x00008AF1 File Offset: 0x00006CF1
		public unsafe bool m_RuntimePropertiesDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_RuntimePropertiesDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_RuntimePropertiesDirty)) = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0009D21C File Offset: 0x0009B41C
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x00008B0C File Offset: 0x00006D0C
		public unsafe static bool ms_NoMainCameraLogged
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_NoMainCameraLogged, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_NoMainCameraLogged, (void*)(&value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0009D238 File Offset: 0x0009B438
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00008B1A File Offset: 0x00006D1A
		public unsafe static Camera ms_MainCamera
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_MainCamera, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_MainCamera, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0009D260 File Offset: 0x0009B460
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00008B2C File Offset: 0x00006D2C
		public unsafe VolumetricLightBeamAbstractBase m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_alpha;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeFieldInfoPtr_density;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeFieldInfoPtr_spawnDistanceRange;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr_spawnMinDistance;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr_spawnMaxDistance;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_cullingEnabled;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_cullingMaxDistance;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr__isCulled_k__BackingField;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaAdditionalRuntime;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr_m_Particles;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_m_Renderer;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_m_GradientCached;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimePropertiesDirty;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr_ms_NoMainCameraLogged;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr_ms_MainCamera;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_get_isCulled_Public_get_Boolean_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_set_isCulled_Private_set_Void_Boolean_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaAdditionalRuntime_Public_get_Single_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaAdditionalRuntime_Public_set_Void_Single_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_get_particlesAreInstantiated_Public_get_Boolean_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_get_particlesCurrentCount_Public_get_Int32_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_get_particlesMaxCount_Public_get_Int32_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_get_mainCamera_Public_get_Camera_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateParticleSystem_Private_Void_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Private_Void_Boolean_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveAndPlay_Private_Void_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_SetParticleProperties_Private_Void_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Private_Void_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000844 RID: 2116
		[ObfuscatedName("VLB.VolumetricDustParticles+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BF83 RID: 49027 RVA: 0x002EEBAC File Offset: 0x002ECDAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr);
				VolumetricDustParticles.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr, "<>9");
				VolumetricDustParticles.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr, "<>9__37_0");
				VolumetricDustParticles.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr, 100665003);
				VolumetricDustParticles.__c.NativeMethodInfoPtr__InstantiateParticleSystem_b__37_0_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr, 100665004);
			}

			// Token: 0x0600BF84 RID: 49028 RVA: 0x002EEC28 File Offset: 0x002ECE28
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF85 RID: 49029 RVA: 0x002EEC64 File Offset: 0x002ECE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85020, XrefRangeEnd = 85033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstantiateParticleSystem_b__37_0(ParticleSystem ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.__c.NativeMethodInfoPtr__InstantiateParticleSystem_b__37_0_Internal_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF86 RID: 49030 RVA: 0x0005D943 File Offset: 0x0005BB43
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B93 RID: 15251
			// (get) Token: 0x0600BF87 RID: 49031 RVA: 0x002EECA8 File Offset: 0x002ECEA8
			// (set) Token: 0x0600BF88 RID: 49032 RVA: 0x0005D94C File Offset: 0x0005BB4C
			public unsafe static VolumetricDustParticles.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricDustParticles.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B94 RID: 15252
			// (get) Token: 0x0600BF89 RID: 49033 RVA: 0x002EECD0 File Offset: 0x002ECED0
			// (set) Token: 0x0600BF8A RID: 49034 RVA: 0x0005D95E File Offset: 0x0005BB5E
			public unsafe static Action<ParticleSystem> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040081C5 RID: 33221
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040081C6 RID: 33222
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x040081C7 RID: 33223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040081C8 RID: 33224
			private static readonly IntPtr NativeMethodInfoPtr__InstantiateParticleSystem_b__37_0_Internal_Void_ParticleSystem_0;
		}
	}
}
