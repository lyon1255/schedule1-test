using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003F7 RID: 1015
	public class FXManager : Singleton<FXManager>
	{
		// Token: 0x0600547F RID: 21631 RVA: 0x0018BFEC File Offset: 0x0018A1EC
		// Note: this type is marked as 'beforefieldinit'.
		static FXManager()
		{
			Il2CppClassPointerStore<FXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "FXManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager>.NativeClassPtr);
			FXManager.NativeFieldInfoPtr_PunchImpactsClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "PunchImpactsClips");
			FXManager.NativeFieldInfoPtr_SlashImpactClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "SlashImpactClips");
			FXManager.NativeFieldInfoPtr_ImpactSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "ImpactSources");
			FXManager.NativeFieldInfoPtr_PunchParticlePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "PunchParticlePrefab");
			FXManager.NativeFieldInfoPtr_BulletTrail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "BulletTrail");
			FXManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673809);
			FXManager.NativeMethodInfoPtr_CreateImpactFX_Public_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673810);
			FXManager.NativeMethodInfoPtr_CreateBulletTrail_Public_Void_Vector3_Vector3_Single_Single_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673811);
			FXManager.NativeMethodInfoPtr_PlayImpact_Private_Void_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673812);
			FXManager.NativeMethodInfoPtr_PlayParticles_Private_Void_GameObject_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673813);
			FXManager.NativeMethodInfoPtr_GetImpactSound_Private_AudioClip_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673814);
			FXManager.NativeMethodInfoPtr_GetImpactParticles_Private_GameObject_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673815);
			FXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673816);
			FXManager.NativeMethodInfoPtr_GetRandomClip_Private_Static_AudioClip_Il2CppReferenceArray_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673817);
			FXManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673818);
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x0018C148 File Offset: 0x0018A348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179923, XrefRangeEnd = 179926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FXManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x0018C184 File Offset: 0x0018A384
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 179963, RefRangeEnd = 179966, XrefRangeStart = 179926, XrefRangeEnd = 179963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateImpactFX(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_CreateImpactFX_Public_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x0018C1C8 File Offset: 0x0018A3C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180001, RefRangeEnd = 180002, XrefRangeStart = 179966, XrefRangeEnd = 180001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateBulletTrail(Vector3 start, Vector3 dir, float speed, float range, LayerMask mask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_CreateBulletTrail_Public_Void_Vector3_Vector3_Single_Single_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x0018C240 File Offset: 0x0018A440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180035, RefRangeEnd = 180036, XrefRangeStart = 180002, XrefRangeEnd = 180035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayImpact(AudioClip clip, Vector3 position, float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_PlayImpact_Private_Void_AudioClip_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x0018C2A0 File Offset: 0x0018A4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180036, XrefRangeEnd = 180043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayParticles(GameObject prefab, Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_PlayParticles_Private_Void_GameObject_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x0018C300 File Offset: 0x0018A500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180043, XrefRangeEnd = 180051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetImpactSound(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetImpactSound_Private_AudioClip_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x0018C350 File Offset: 0x0018A550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180051, XrefRangeEnd = 180059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetImpactParticles(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetImpactParticles_Private_GameObject_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x0018C3A0 File Offset: 0x0018A5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180059, XrefRangeEnd = 180077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController GetSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr3) : null;
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x0018C3E0 File Offset: 0x0018A5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180077, XrefRangeEnd = 180078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioClip GetRandomClip(Il2CppReferenceArray<AudioClip> clips)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clips);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetRandomClip_Private_Static_AudioClip_Il2CppReferenceArray_1_AudioClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x0018C424 File Offset: 0x0018A624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180078, XrefRangeEnd = 180081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x00028820 File Offset: 0x00026A20
		public FXManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x0600548B RID: 21643 RVA: 0x0018C460 File Offset: 0x0018A660
		// (set) Token: 0x0600548C RID: 21644 RVA: 0x00028829 File Offset: 0x00026A29
		public unsafe Il2CppReferenceArray<AudioClip> PunchImpactsClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchImpactsClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchImpactsClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x0600548D RID: 21645 RVA: 0x0018C490 File Offset: 0x0018A690
		// (set) Token: 0x0600548E RID: 21646 RVA: 0x00028848 File Offset: 0x00026A48
		public unsafe Il2CppReferenceArray<AudioClip> SlashImpactClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_SlashImpactClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_SlashImpactClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x0600548F RID: 21647 RVA: 0x0018C4C0 File Offset: 0x0018A6C0
		// (set) Token: 0x06005490 RID: 21648 RVA: 0x00028867 File Offset: 0x00026A67
		public unsafe Il2CppReferenceArray<AudioSourceController> ImpactSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_ImpactSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_ImpactSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06005491 RID: 21649 RVA: 0x0018C4F0 File Offset: 0x0018A6F0
		// (set) Token: 0x06005492 RID: 21650 RVA: 0x00028886 File Offset: 0x00026A86
		public unsafe GameObject PunchParticlePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchParticlePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchParticlePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06005493 RID: 21651 RVA: 0x0018C520 File Offset: 0x0018A720
		// (set) Token: 0x06005494 RID: 21652 RVA: 0x000288A5 File Offset: 0x00026AA5
		public unsafe TrailRenderer BulletTrail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_BulletTrail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_BulletTrail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003936 RID: 14646
		private static readonly IntPtr NativeFieldInfoPtr_PunchImpactsClips;

		// Token: 0x04003937 RID: 14647
		private static readonly IntPtr NativeFieldInfoPtr_SlashImpactClips;

		// Token: 0x04003938 RID: 14648
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSources;

		// Token: 0x04003939 RID: 14649
		private static readonly IntPtr NativeFieldInfoPtr_PunchParticlePrefab;

		// Token: 0x0400393A RID: 14650
		private static readonly IntPtr NativeFieldInfoPtr_BulletTrail;

		// Token: 0x0400393B RID: 14651
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400393C RID: 14652
		private static readonly IntPtr NativeMethodInfoPtr_CreateImpactFX_Public_Void_Impact_0;

		// Token: 0x0400393D RID: 14653
		private static readonly IntPtr NativeMethodInfoPtr_CreateBulletTrail_Public_Void_Vector3_Vector3_Single_Single_LayerMask_0;

		// Token: 0x0400393E RID: 14654
		private static readonly IntPtr NativeMethodInfoPtr_PlayImpact_Private_Void_AudioClip_Vector3_Single_0;

		// Token: 0x0400393F RID: 14655
		private static readonly IntPtr NativeMethodInfoPtr_PlayParticles_Private_Void_GameObject_Vector3_Quaternion_0;

		// Token: 0x04003940 RID: 14656
		private static readonly IntPtr NativeMethodInfoPtr_GetImpactSound_Private_AudioClip_Impact_0;

		// Token: 0x04003941 RID: 14657
		private static readonly IntPtr NativeMethodInfoPtr_GetImpactParticles_Private_GameObject_Impact_0;

		// Token: 0x04003942 RID: 14658
		private static readonly IntPtr NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0;

		// Token: 0x04003943 RID: 14659
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomClip_Private_Static_AudioClip_Il2CppReferenceArray_1_AudioClip_0;

		// Token: 0x04003944 RID: 14660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B7 RID: 2487
		[ObfuscatedName("ScheduleOne.FX.FXManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CBF9 RID: 52217 RVA: 0x00313668 File Offset: 0x00311868
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr);
				FXManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, "<>9");
				FXManager.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, "<>9__12_0");
				FXManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, 100673820);
				FXManager.__c.NativeMethodInfoPtr__GetSource_b__12_0_Internal_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, 100673821);
			}

			// Token: 0x0600CBFA RID: 52218 RVA: 0x003136E4 File Offset: 0x003118E4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBFB RID: 52219 RVA: 0x00313720 File Offset: 0x00311920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179905, XrefRangeEnd = 179906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSource_b__12_0(AudioSourceController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c.NativeMethodInfoPtr__GetSource_b__12_0_Internal_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBFC RID: 52220 RVA: 0x0006339B File Offset: 0x0006159B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F8D RID: 16269
			// (get) Token: 0x0600CBFD RID: 52221 RVA: 0x00313770 File Offset: 0x00311970
			// (set) Token: 0x0600CBFE RID: 52222 RVA: 0x000633A4 File Offset: 0x000615A4
			public unsafe static FXManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FXManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FXManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F8E RID: 16270
			// (get) Token: 0x0600CBFF RID: 52223 RVA: 0x00313798 File Offset: 0x00311998
			// (set) Token: 0x0600CC00 RID: 52224 RVA: 0x000633B6 File Offset: 0x000615B6
			public unsafe static Func<AudioSourceController, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FXManager.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AudioSourceController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FXManager.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089E6 RID: 35302
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040089E7 RID: 35303
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040089E8 RID: 35304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089E9 RID: 35305
			private static readonly IntPtr NativeMethodInfoPtr__GetSource_b__12_0_Internal_Boolean_AudioSourceController_0;
		}

		// Token: 0x020009B8 RID: 2488
		[ObfuscatedName("ScheduleOne.FX.FXManager+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC01 RID: 52225 RVA: 0x003137C0 File Offset: 0x003119C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr);
				FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, "trail");
				FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, "start");
				FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, "maxDistance");
				FXManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, 100673822);
				FXManager.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, 100673823);
			}

			// Token: 0x0600CC02 RID: 52226 RVA: 0x00313850 File Offset: 0x00311A50
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC03 RID: 52227 RVA: 0x0031388C File Offset: 0x00311A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179918, XrefRangeEnd = 179923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CC04 RID: 52228 RVA: 0x000633C8 File Offset: 0x000615C8
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F8F RID: 16271
			// (get) Token: 0x0600CC05 RID: 52229 RVA: 0x003138CC File Offset: 0x00311ACC
			// (set) Token: 0x0600CC06 RID: 52230 RVA: 0x000633D1 File Offset: 0x000615D1
			public unsafe TrailRenderer trail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_trail);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_trail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F90 RID: 16272
			// (get) Token: 0x0600CC07 RID: 52231 RVA: 0x003138FC File Offset: 0x00311AFC
			// (set) Token: 0x0600CC08 RID: 52232 RVA: 0x000633F0 File Offset: 0x000615F0
			public unsafe Vector3 start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x17003F91 RID: 16273
			// (get) Token: 0x0600CC09 RID: 52233 RVA: 0x00313924 File Offset: 0x00311B24
			// (set) Token: 0x0600CC0A RID: 52234 RVA: 0x0006340B File Offset: 0x0006160B
			public unsafe float maxDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_maxDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_maxDistance)) = value;
				}
			}

			// Token: 0x040089EA RID: 35306
			private static readonly IntPtr NativeFieldInfoPtr_trail;

			// Token: 0x040089EB RID: 35307
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x040089EC RID: 35308
			private static readonly IntPtr NativeFieldInfoPtr_maxDistance;

			// Token: 0x040089ED RID: 35309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089EE RID: 35310
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C49 RID: 3145
			[ObfuscatedName("ScheduleOne.FX.FXManager+<>c__DisplayClass7_0+<<CreateBulletTrail>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E2B5 RID: 58037 RVA: 0x00353AE0 File Offset: 0x00351CE0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, "<<CreateBulletTrail>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673824);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673825);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673826);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673827);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673828);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673829);
				}

				// Token: 0x0600E2B6 RID: 58038 RVA: 0x00353BC0 File Offset: 0x00351DC0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2B7 RID: 58039 RVA: 0x00353C08 File Offset: 0x00351E08
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2B8 RID: 58040 RVA: 0x00353C3C File Offset: 0x00351E3C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179906, XrefRangeEnd = 179913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004656 RID: 18006
				// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x00353C78 File Offset: 0x00351E78
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2BA RID: 58042 RVA: 0x00353CB8 File Offset: 0x00351EB8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179913, XrefRangeEnd = 179918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004657 RID: 18007
				// (get) Token: 0x0600E2BB RID: 58043 RVA: 0x00353CEC File Offset: 0x00351EEC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2BC RID: 58044 RVA: 0x0006E882 File Offset: 0x0006CA82
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004653 RID: 18003
				// (get) Token: 0x0600E2BD RID: 58045 RVA: 0x00353D2C File Offset: 0x00351F2C
				// (set) Token: 0x0600E2BE RID: 58046 RVA: 0x0006E88B File Offset: 0x0006CA8B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004654 RID: 18004
				// (get) Token: 0x0600E2BF RID: 58047 RVA: 0x00353D54 File Offset: 0x00351F54
				// (set) Token: 0x0600E2C0 RID: 58048 RVA: 0x0006E8A6 File Offset: 0x0006CAA6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004655 RID: 18005
				// (get) Token: 0x0600E2C1 RID: 58049 RVA: 0x00353D84 File Offset: 0x00351F84
				// (set) Token: 0x0600E2C2 RID: 58050 RVA: 0x0006E8C5 File Offset: 0x0006CAC5
				public unsafe FXManager.__c__DisplayClass7_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXManager.__c__DisplayClass7_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097BC RID: 38844
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097BD RID: 38845
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097BE RID: 38846
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097BF RID: 38847
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097C0 RID: 38848
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097C1 RID: 38849
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097C2 RID: 38850
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097C3 RID: 38851
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097C4 RID: 38852
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
