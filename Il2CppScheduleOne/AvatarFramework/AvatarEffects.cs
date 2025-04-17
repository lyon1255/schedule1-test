using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.FX;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F1 RID: 1521
	public class AvatarEffects : MonoBehaviour
	{
		// Token: 0x06008549 RID: 34121 RVA: 0x00235558 File Offset: 0x00233758
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEffects()
		{
			Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr);
			AvatarEffects.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "Avatar");
			AvatarEffects.NativeFieldInfoPtr_StinkParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "StinkParticles");
			AvatarEffects.NativeFieldInfoPtr_VomitParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "VomitParticles");
			AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadPoofParticles");
			AvatarEffects.NativeFieldInfoPtr_FartParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FartParticles");
			AvatarEffects.NativeFieldInfoPtr_AntiGravParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AntiGravParticles");
			AvatarEffects.NativeFieldInfoPtr_FireParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireParticles");
			AvatarEffects.NativeFieldInfoPtr_FireLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireLight");
			AvatarEffects.NativeFieldInfoPtr_FoggyEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FoggyEffects");
			AvatarEffects.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadBone");
			AvatarEffects.NativeFieldInfoPtr_NeckBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "NeckBone");
			AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "MirrorEffectsTo");
			AvatarEffects.NativeFieldInfoPtr_ZapParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapParticles");
			AvatarEffects.NativeFieldInfoPtr_CountdownExplosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "CountdownExplosion");
			AvatarEffects.NativeFieldInfoPtr_ObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ObjectsToCull");
			AvatarEffects.NativeFieldInfoPtr_DisableHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "DisableHead");
			AvatarEffects.NativeFieldInfoPtr_GurgleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "GurgleSound");
			AvatarEffects.NativeFieldInfoPtr_VomitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "VomitSound");
			AvatarEffects.NativeFieldInfoPtr_PoofSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "PoofSound");
			AvatarEffects.NativeFieldInfoPtr_FartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FartSound");
			AvatarEffects.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireSound");
			AvatarEffects.NativeFieldInfoPtr_ZapSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapSound");
			AvatarEffects.NativeFieldInfoPtr_ZapLoopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapLoopSound");
			AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AdditionalWeightController");
			AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AdditionalGenderController");
			AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadSizeBoost");
			AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "NeckSizeBoost");
			AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "SkinColorSmoother");
			AvatarEffects.NativeFieldInfoPtr_laxativeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "laxativeEnabled");
			AvatarEffects.NativeFieldInfoPtr_currentEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "currentEmission");
			AvatarEffects.NativeFieldInfoPtr_targetEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "targetEmission");
			AvatarEffects.NativeFieldInfoPtr_isCulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "isCulled");
			AvatarEffects.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679953);
			AvatarEffects.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679954);
			AvatarEffects.NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679955);
			AvatarEffects.NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679956);
			AvatarEffects.NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679957);
			AvatarEffects.NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679958);
			AvatarEffects.NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679959);
			AvatarEffects.NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679960);
			AvatarEffects.NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679961);
			AvatarEffects.NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679962);
			AvatarEffects.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679963);
			AvatarEffects.NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679964);
			AvatarEffects.NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679965);
			AvatarEffects.NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679966);
			AvatarEffects.NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679967);
			AvatarEffects.NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679968);
			AvatarEffects.NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679969);
			AvatarEffects.NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679970);
			AvatarEffects.NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679971);
			AvatarEffects.NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679972);
			AvatarEffects.NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679973);
			AvatarEffects.NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679974);
			AvatarEffects.NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679975);
			AvatarEffects.NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679976);
			AvatarEffects.NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679977);
			AvatarEffects.NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679978);
			AvatarEffects.NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679979);
			AvatarEffects.NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679980);
			AvatarEffects.NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679981);
			AvatarEffects.NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679982);
			AvatarEffects.NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679983);
			AvatarEffects.NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679984);
			AvatarEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679985);
			AvatarEffects.NativeMethodInfoPtr__Start_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679986);
			AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679987);
			AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679988);
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x00235AD8 File Offset: 0x00233CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249841, XrefRangeEnd = 249863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600854B RID: 34123 RVA: 0x00235B0C File Offset: 0x00233D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249863, XrefRangeEnd = 249903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600854C RID: 34124 RVA: 0x00235B40 File Offset: 0x00233D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249903, XrefRangeEnd = 249905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEffectsCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref culled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600854D RID: 34125 RVA: 0x00235B80 File Offset: 0x00233D80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 249911, RefRangeEnd = 249916, XrefRangeStart = 249905, XrefRangeEnd = 249911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStinkParticlesActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600854E RID: 34126 RVA: 0x00235BCC File Offset: 0x00233DCC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 249926, RefRangeEnd = 249933, XrefRangeStart = 249916, XrefRangeEnd = 249926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSick(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600854F RID: 34127 RVA: 0x00235C0C File Offset: 0x00233E0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 249936, RefRangeEnd = 249941, XrefRangeStart = 249933, XrefRangeEnd = 249936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAntiGrav(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008550 RID: 34128 RVA: 0x00235C58 File Offset: 0x00233E58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 249944, RefRangeEnd = 249949, XrefRangeStart = 249941, XrefRangeEnd = 249944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFoggy(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008551 RID: 34129 RVA: 0x00235CA4 File Offset: 0x00233EA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249957, RefRangeEnd = 249960, XrefRangeStart = 249949, XrefRangeEnd = 249957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VanishHair(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008552 RID: 34130 RVA: 0x00235CE4 File Offset: 0x00233EE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 249971, RefRangeEnd = 249977, XrefRangeStart = 249960, XrefRangeEnd = 249971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZapped(bool zapped, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref zapped;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008553 RID: 34131 RVA: 0x00235D30 File Offset: 0x00233F30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249985, RefRangeEnd = 249988, XrefRangeStart = 249977, XrefRangeEnd = 249985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnHair(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008554 RID: 34132 RVA: 0x00235D70 File Offset: 0x00233F70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250005, RefRangeEnd = 250008, XrefRangeStart = 249988, XrefRangeEnd = 250005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideHairColor(Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008555 RID: 34133 RVA: 0x00235DBC File Offset: 0x00233FBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250012, RefRangeEnd = 250015, XrefRangeStart = 250008, XrefRangeEnd = 250012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHairColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008556 RID: 34134 RVA: 0x00235DFC File Offset: 0x00233FFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250019, RefRangeEnd = 250024, XrefRangeStart = 250015, XrefRangeEnd = 250019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeColor(Color color, float emission = 0.115f, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emission;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008557 RID: 34135 RVA: 0x00235E58 File Offset: 0x00234058
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250028, RefRangeEnd = 250033, XrefRangeStart = 250024, XrefRangeEnd = 250028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008558 RID: 34136 RVA: 0x00235E98 File Offset: 0x00234098
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250037, RefRangeEnd = 250042, XrefRangeStart = 250033, XrefRangeEnd = 250037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLightEmission(float intensity, Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008559 RID: 34137 RVA: 0x00235EF4 File Offset: 0x002340F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250056, RefRangeEnd = 250059, XrefRangeStart = 250042, XrefRangeEnd = 250056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableLaxative(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x00235F34 File Offset: 0x00234134
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250061, RefRangeEnd = 250064, XrefRangeStart = 250059, XrefRangeEnd = 250061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableLaxative(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x00235F74 File Offset: 0x00234174
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250067, RefRangeEnd = 250072, XrefRangeStart = 250064, XrefRangeEnd = 250067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFireActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x00235FC0 File Offset: 0x002341C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250080, RefRangeEnd = 250085, XrefRangeStart = 250072, XrefRangeEnd = 250080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBigHeadActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600855D RID: 34141 RVA: 0x0023600C File Offset: 0x0023420C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250097, RefRangeEnd = 250102, XrefRangeStart = 250085, XrefRangeEnd = 250097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGiraffeActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600855E RID: 34142 RVA: 0x00236058 File Offset: 0x00234258
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250115, RefRangeEnd = 250120, XrefRangeStart = 250102, XrefRangeEnd = 250115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkinColorInverted(bool inverted, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inverted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600855F RID: 34143 RVA: 0x002360A4 File Offset: 0x002342A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250133, RefRangeEnd = 250138, XrefRangeStart = 250120, XrefRangeEnd = 250133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSicklySkinColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008560 RID: 34144 RVA: 0x002360E4 File Offset: 0x002342E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250145, RefRangeEnd = 250148, XrefRangeStart = 250138, XrefRangeEnd = 250145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultSkinColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008561 RID: 34145 RVA: 0x00236124 File Offset: 0x00234324
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250158, RefRangeEnd = 250163, XrefRangeStart = 250148, XrefRangeEnd = 250158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGenderInverted(bool inverted, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inverted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008562 RID: 34146 RVA: 0x00236170 File Offset: 0x00234370
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250166, RefRangeEnd = 250169, XrefRangeStart = 250163, XrefRangeEnd = 250166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAdditionalWeightOverride(float value, int priority, string label, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008563 RID: 34147 RVA: 0x002361DC File Offset: 0x002343DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250172, RefRangeEnd = 250175, XrefRangeStart = 250169, XrefRangeEnd = 250172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAdditionalWeightOverride(string label, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008564 RID: 34148 RVA: 0x0023622C File Offset: 0x0023442C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250177, RefRangeEnd = 250180, XrefRangeStart = 250175, XrefRangeEnd = 250177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlowingOn(Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008565 RID: 34149 RVA: 0x00236278 File Offset: 0x00234478
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250182, RefRangeEnd = 250185, XrefRangeStart = 250180, XrefRangeEnd = 250182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlowingOff(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x002362B8 File Offset: 0x002344B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250188, RefRangeEnd = 250191, XrefRangeStart = 250185, XrefRangeEnd = 250188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerCountdownExplosion(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008567 RID: 34151 RVA: 0x002362F8 File Offset: 0x002344F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250194, RefRangeEnd = 250197, XrefRangeStart = 250191, XrefRangeEnd = 250194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCountdownExplosion(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008568 RID: 34152 RVA: 0x00236338 File Offset: 0x00234538
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250216, RefRangeEnd = 250221, XrefRangeStart = 250197, XrefRangeEnd = 250216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCyclopean(bool enabled, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008569 RID: 34153 RVA: 0x00236384 File Offset: 0x00234584
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250246, RefRangeEnd = 250251, XrefRangeStart = 250221, XrefRangeEnd = 250246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZombified(bool zombified, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref zombified;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856A RID: 34154 RVA: 0x002363D0 File Offset: 0x002345D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250251, XrefRangeEnd = 250252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEffects() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x0023640C File Offset: 0x0023460C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250252, XrefRangeEnd = 250253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__32_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr__Start_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x00236440 File Offset: 0x00234640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250253, XrefRangeEnd = 250258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x00236480 File Offset: 0x00234680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250258, XrefRangeEnd = 250263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600856E RID: 34158 RVA: 0x0003F43E File Offset: 0x0003D63E
		public AvatarEffects(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600856F RID: 34159 RVA: 0x002364C0 File Offset: 0x002346C0
		// (set) Token: 0x06008570 RID: 34160 RVA: 0x0003F447 File Offset: 0x0003D647
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x06008571 RID: 34161 RVA: 0x002364F0 File Offset: 0x002346F0
		// (set) Token: 0x06008572 RID: 34162 RVA: 0x0003F466 File Offset: 0x0003D666
		public unsafe Il2CppReferenceArray<ParticleSystem> StinkParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_StinkParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_StinkParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x06008573 RID: 34163 RVA: 0x00236520 File Offset: 0x00234720
		// (set) Token: 0x06008574 RID: 34164 RVA: 0x0003F485 File Offset: 0x0003D685
		public unsafe ParticleSystem VomitParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x06008575 RID: 34165 RVA: 0x00236550 File Offset: 0x00234750
		// (set) Token: 0x06008576 RID: 34166 RVA: 0x0003F4A4 File Offset: 0x0003D6A4
		public unsafe ParticleSystem HeadPoofParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x06008577 RID: 34167 RVA: 0x00236580 File Offset: 0x00234780
		// (set) Token: 0x06008578 RID: 34168 RVA: 0x0003F4C3 File Offset: 0x0003D6C3
		public unsafe ParticleSystem FartParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x06008579 RID: 34169 RVA: 0x002365B0 File Offset: 0x002347B0
		// (set) Token: 0x0600857A RID: 34170 RVA: 0x0003F4E2 File Offset: 0x0003D6E2
		public unsafe ParticleSystem AntiGravParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AntiGravParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AntiGravParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x0600857B RID: 34171 RVA: 0x002365E0 File Offset: 0x002347E0
		// (set) Token: 0x0600857C RID: 34172 RVA: 0x0003F501 File Offset: 0x0003D701
		public unsafe ParticleSystem FireParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x0600857D RID: 34173 RVA: 0x00236610 File Offset: 0x00234810
		// (set) Token: 0x0600857E RID: 34174 RVA: 0x0003F520 File Offset: 0x0003D720
		public unsafe OptimizedLight FireLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x0600857F RID: 34175 RVA: 0x00236640 File Offset: 0x00234840
		// (set) Token: 0x06008580 RID: 34176 RVA: 0x0003F53F File Offset: 0x0003D73F
		public unsafe ParticleSystem FoggyEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FoggyEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FoggyEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x06008581 RID: 34177 RVA: 0x00236670 File Offset: 0x00234870
		// (set) Token: 0x06008582 RID: 34178 RVA: 0x0003F55E File Offset: 0x0003D75E
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x06008583 RID: 34179 RVA: 0x002366A0 File Offset: 0x002348A0
		// (set) Token: 0x06008584 RID: 34180 RVA: 0x0003F57D File Offset: 0x0003D77D
		public unsafe Transform NeckBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x06008585 RID: 34181 RVA: 0x002366D0 File Offset: 0x002348D0
		// (set) Token: 0x06008586 RID: 34182 RVA: 0x0003F59C File Offset: 0x0003D79C
		public unsafe Il2CppReferenceArray<AvatarEffects> MirrorEffectsTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarEffects>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x06008587 RID: 34183 RVA: 0x00236700 File Offset: 0x00234900
		// (set) Token: 0x06008588 RID: 34184 RVA: 0x0003F5BB File Offset: 0x0003D7BB
		public unsafe ParticleSystem ZapParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x06008589 RID: 34185 RVA: 0x00236730 File Offset: 0x00234930
		// (set) Token: 0x0600858A RID: 34186 RVA: 0x0003F5DA File Offset: 0x0003D7DA
		public unsafe CountdownExplosion CountdownExplosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_CountdownExplosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CountdownExplosion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_CountdownExplosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x0600858B RID: 34187 RVA: 0x00236760 File Offset: 0x00234960
		// (set) Token: 0x0600858C RID: 34188 RVA: 0x0003F5F9 File Offset: 0x0003D7F9
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ObjectsToCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x0600858D RID: 34189 RVA: 0x00236790 File Offset: 0x00234990
		// (set) Token: 0x0600858E RID: 34190 RVA: 0x0003F618 File Offset: 0x0003D818
		public unsafe bool DisableHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_DisableHead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_DisableHead)) = value;
			}
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x0600858F RID: 34191 RVA: 0x002367B8 File Offset: 0x002349B8
		// (set) Token: 0x06008590 RID: 34192 RVA: 0x0003F633 File Offset: 0x0003D833
		public unsafe AudioSourceController GurgleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_GurgleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_GurgleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x06008591 RID: 34193 RVA: 0x002367E8 File Offset: 0x002349E8
		// (set) Token: 0x06008592 RID: 34194 RVA: 0x0003F652 File Offset: 0x0003D852
		public unsafe AudioSourceController VomitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x06008593 RID: 34195 RVA: 0x00236818 File Offset: 0x00234A18
		// (set) Token: 0x06008594 RID: 34196 RVA: 0x0003F671 File Offset: 0x0003D871
		public unsafe AudioSourceController PoofSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_PoofSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_PoofSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x06008595 RID: 34197 RVA: 0x00236848 File Offset: 0x00234A48
		// (set) Token: 0x06008596 RID: 34198 RVA: 0x0003F690 File Offset: 0x0003D890
		public unsafe AudioSourceController FartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x06008597 RID: 34199 RVA: 0x00236878 File Offset: 0x00234A78
		// (set) Token: 0x06008598 RID: 34200 RVA: 0x0003F6AF File Offset: 0x0003D8AF
		public unsafe AudioSourceController FireSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x06008599 RID: 34201 RVA: 0x002368A8 File Offset: 0x00234AA8
		// (set) Token: 0x0600859A RID: 34202 RVA: 0x0003F6CE File Offset: 0x0003D8CE
		public unsafe AudioSourceController ZapSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x0600859B RID: 34203 RVA: 0x002368D8 File Offset: 0x00234AD8
		// (set) Token: 0x0600859C RID: 34204 RVA: 0x0003F6ED File Offset: 0x0003D8ED
		public unsafe AudioSourceController ZapLoopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapLoopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapLoopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x0600859D RID: 34205 RVA: 0x00236908 File Offset: 0x00234B08
		// (set) Token: 0x0600859E RID: 34206 RVA: 0x0003F70C File Offset: 0x0003D90C
		public unsafe FloatSmoother AdditionalWeightController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x0600859F RID: 34207 RVA: 0x00236938 File Offset: 0x00234B38
		// (set) Token: 0x060085A0 RID: 34208 RVA: 0x0003F72B File Offset: 0x0003D92B
		public unsafe FloatSmoother AdditionalGenderController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x060085A1 RID: 34209 RVA: 0x00236968 File Offset: 0x00234B68
		// (set) Token: 0x060085A2 RID: 34210 RVA: 0x0003F74A File Offset: 0x0003D94A
		public unsafe FloatSmoother HeadSizeBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x060085A3 RID: 34211 RVA: 0x00236998 File Offset: 0x00234B98
		// (set) Token: 0x060085A4 RID: 34212 RVA: 0x0003F769 File Offset: 0x0003D969
		public unsafe FloatSmoother NeckSizeBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x060085A5 RID: 34213 RVA: 0x002369C8 File Offset: 0x00234BC8
		// (set) Token: 0x060085A6 RID: 34214 RVA: 0x0003F788 File Offset: 0x0003D988
		public unsafe ColorSmoother SkinColorSmoother
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x060085A7 RID: 34215 RVA: 0x002369F8 File Offset: 0x00234BF8
		// (set) Token: 0x060085A8 RID: 34216 RVA: 0x0003F7A7 File Offset: 0x0003D9A7
		public unsafe bool laxativeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_laxativeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_laxativeEnabled)) = value;
			}
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x060085A9 RID: 34217 RVA: 0x00236A20 File Offset: 0x00234C20
		// (set) Token: 0x060085AA RID: 34218 RVA: 0x0003F7C2 File Offset: 0x0003D9C2
		public unsafe Color currentEmission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_currentEmission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_currentEmission)) = value;
			}
		}

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x060085AB RID: 34219 RVA: 0x00236A48 File Offset: 0x00234C48
		// (set) Token: 0x060085AC RID: 34220 RVA: 0x0003F7DD File Offset: 0x0003D9DD
		public unsafe Color targetEmission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_targetEmission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_targetEmission)) = value;
			}
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x060085AD RID: 34221 RVA: 0x00236A70 File Offset: 0x00234C70
		// (set) Token: 0x060085AE RID: 34222 RVA: 0x0003F7F8 File Offset: 0x0003D9F8
		public unsafe bool isCulled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_isCulled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_isCulled)) = value;
			}
		}

		// Token: 0x04005ABF RID: 23231
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005AC0 RID: 23232
		private static readonly IntPtr NativeFieldInfoPtr_StinkParticles;

		// Token: 0x04005AC1 RID: 23233
		private static readonly IntPtr NativeFieldInfoPtr_VomitParticles;

		// Token: 0x04005AC2 RID: 23234
		private static readonly IntPtr NativeFieldInfoPtr_HeadPoofParticles;

		// Token: 0x04005AC3 RID: 23235
		private static readonly IntPtr NativeFieldInfoPtr_FartParticles;

		// Token: 0x04005AC4 RID: 23236
		private static readonly IntPtr NativeFieldInfoPtr_AntiGravParticles;

		// Token: 0x04005AC5 RID: 23237
		private static readonly IntPtr NativeFieldInfoPtr_FireParticles;

		// Token: 0x04005AC6 RID: 23238
		private static readonly IntPtr NativeFieldInfoPtr_FireLight;

		// Token: 0x04005AC7 RID: 23239
		private static readonly IntPtr NativeFieldInfoPtr_FoggyEffects;

		// Token: 0x04005AC8 RID: 23240
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04005AC9 RID: 23241
		private static readonly IntPtr NativeFieldInfoPtr_NeckBone;

		// Token: 0x04005ACA RID: 23242
		private static readonly IntPtr NativeFieldInfoPtr_MirrorEffectsTo;

		// Token: 0x04005ACB RID: 23243
		private static readonly IntPtr NativeFieldInfoPtr_ZapParticles;

		// Token: 0x04005ACC RID: 23244
		private static readonly IntPtr NativeFieldInfoPtr_CountdownExplosion;

		// Token: 0x04005ACD RID: 23245
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToCull;

		// Token: 0x04005ACE RID: 23246
		private static readonly IntPtr NativeFieldInfoPtr_DisableHead;

		// Token: 0x04005ACF RID: 23247
		private static readonly IntPtr NativeFieldInfoPtr_GurgleSound;

		// Token: 0x04005AD0 RID: 23248
		private static readonly IntPtr NativeFieldInfoPtr_VomitSound;

		// Token: 0x04005AD1 RID: 23249
		private static readonly IntPtr NativeFieldInfoPtr_PoofSound;

		// Token: 0x04005AD2 RID: 23250
		private static readonly IntPtr NativeFieldInfoPtr_FartSound;

		// Token: 0x04005AD3 RID: 23251
		private static readonly IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04005AD4 RID: 23252
		private static readonly IntPtr NativeFieldInfoPtr_ZapSound;

		// Token: 0x04005AD5 RID: 23253
		private static readonly IntPtr NativeFieldInfoPtr_ZapLoopSound;

		// Token: 0x04005AD6 RID: 23254
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalWeightController;

		// Token: 0x04005AD7 RID: 23255
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalGenderController;

		// Token: 0x04005AD8 RID: 23256
		private static readonly IntPtr NativeFieldInfoPtr_HeadSizeBoost;

		// Token: 0x04005AD9 RID: 23257
		private static readonly IntPtr NativeFieldInfoPtr_NeckSizeBoost;

		// Token: 0x04005ADA RID: 23258
		private static readonly IntPtr NativeFieldInfoPtr_SkinColorSmoother;

		// Token: 0x04005ADB RID: 23259
		private static readonly IntPtr NativeFieldInfoPtr_laxativeEnabled;

		// Token: 0x04005ADC RID: 23260
		private static readonly IntPtr NativeFieldInfoPtr_currentEmission;

		// Token: 0x04005ADD RID: 23261
		private static readonly IntPtr NativeFieldInfoPtr_targetEmission;

		// Token: 0x04005ADE RID: 23262
		private static readonly IntPtr NativeFieldInfoPtr_isCulled;

		// Token: 0x04005ADF RID: 23263
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005AE0 RID: 23264
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04005AE1 RID: 23265
		private static readonly IntPtr NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0;

		// Token: 0x04005AE2 RID: 23266
		private static readonly IntPtr NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AE3 RID: 23267
		private static readonly IntPtr NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0;

		// Token: 0x04005AE4 RID: 23268
		private static readonly IntPtr NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AE5 RID: 23269
		private static readonly IntPtr NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AE6 RID: 23270
		private static readonly IntPtr NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0;

		// Token: 0x04005AE7 RID: 23271
		private static readonly IntPtr NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AE8 RID: 23272
		private static readonly IntPtr NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0;

		// Token: 0x04005AE9 RID: 23273
		private static readonly IntPtr NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0;

		// Token: 0x04005AEA RID: 23274
		private static readonly IntPtr NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0;

		// Token: 0x04005AEB RID: 23275
		private static readonly IntPtr NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0;

		// Token: 0x04005AEC RID: 23276
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0;

		// Token: 0x04005AED RID: 23277
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0;

		// Token: 0x04005AEE RID: 23278
		private static readonly IntPtr NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0;

		// Token: 0x04005AEF RID: 23279
		private static readonly IntPtr NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0;

		// Token: 0x04005AF0 RID: 23280
		private static readonly IntPtr NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AF1 RID: 23281
		private static readonly IntPtr NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AF2 RID: 23282
		private static readonly IntPtr NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AF3 RID: 23283
		private static readonly IntPtr NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AF4 RID: 23284
		private static readonly IntPtr NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0;

		// Token: 0x04005AF5 RID: 23285
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0;

		// Token: 0x04005AF6 RID: 23286
		private static readonly IntPtr NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AF7 RID: 23287
		private static readonly IntPtr NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0;

		// Token: 0x04005AF8 RID: 23288
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0;

		// Token: 0x04005AF9 RID: 23289
		private static readonly IntPtr NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0;

		// Token: 0x04005AFA RID: 23290
		private static readonly IntPtr NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0;

		// Token: 0x04005AFB RID: 23291
		private static readonly IntPtr NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0;

		// Token: 0x04005AFC RID: 23292
		private static readonly IntPtr NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0;

		// Token: 0x04005AFD RID: 23293
		private static readonly IntPtr NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AFE RID: 23294
		private static readonly IntPtr NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AFF RID: 23295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005B00 RID: 23296
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__32_0_Private_Void_0;

		// Token: 0x04005B01 RID: 23297
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005B02 RID: 23298
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000AEA RID: 2794
		[ObfuscatedName("ScheduleOne.AvatarFramework.AvatarEffects+<<EnableLaxative>g__Routine|47_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600D561 RID: 54625 RVA: 0x0032DC00 File Offset: 0x0032BE00
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "<<EnableLaxative>g__Routine|47_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100679989);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100679990);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100679991);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100679992);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100679993);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100679994);
			}

			// Token: 0x0600D562 RID: 54626 RVA: 0x0032DCE0 File Offset: 0x0032BEE0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D563 RID: 54627 RVA: 0x0032DD28 File Offset: 0x0032BF28
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D564 RID: 54628 RVA: 0x0032DD5C File Offset: 0x0032BF5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249817, XrefRangeEnd = 249825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004221 RID: 16929
			// (get) Token: 0x0600D565 RID: 54629 RVA: 0x0032DD98 File Offset: 0x0032BF98
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D566 RID: 54630 RVA: 0x0032DDD8 File Offset: 0x0032BFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249825, XrefRangeEnd = 249830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004222 RID: 16930
			// (get) Token: 0x0600D567 RID: 54631 RVA: 0x0032DE0C File Offset: 0x0032C00C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D568 RID: 54632 RVA: 0x00067CE0 File Offset: 0x00065EE0
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700421E RID: 16926
			// (get) Token: 0x0600D569 RID: 54633 RVA: 0x0032DE4C File Offset: 0x0032C04C
			// (set) Token: 0x0600D56A RID: 54634 RVA: 0x00067CE9 File Offset: 0x00065EE9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700421F RID: 16927
			// (get) Token: 0x0600D56B RID: 54635 RVA: 0x0032DE74 File Offset: 0x0032C074
			// (set) Token: 0x0600D56C RID: 54636 RVA: 0x00067D04 File Offset: 0x00065F04
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004220 RID: 16928
			// (get) Token: 0x0600D56D RID: 54637 RVA: 0x0032DEA4 File Offset: 0x0032C0A4
			// (set) Token: 0x0600D56E RID: 54638 RVA: 0x00067D23 File Offset: 0x00065F23
			public unsafe AvatarEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F8B RID: 36747
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F8C RID: 36748
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F8D RID: 36749
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F8E RID: 36750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F8F RID: 36751
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F90 RID: 36752
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F91 RID: 36753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F92 RID: 36754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F93 RID: 36755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AEB RID: 2795
		[ObfuscatedName("ScheduleOne.AvatarFramework.AvatarEffects+<<TriggerSick>g__Routine|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600D56F RID: 54639 RVA: 0x0032DED4 File Offset: 0x0032C0D4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "<<TriggerSick>g__Routine|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100679995);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100679996);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100679997);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100679998);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100679999);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680000);
			}

			// Token: 0x0600D570 RID: 54640 RVA: 0x0032DFB4 File Offset: 0x0032C1B4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D571 RID: 54641 RVA: 0x0032DFFC File Offset: 0x0032C1FC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D572 RID: 54642 RVA: 0x0032E030 File Offset: 0x0032C230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249830, XrefRangeEnd = 249836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004226 RID: 16934
			// (get) Token: 0x0600D573 RID: 54643 RVA: 0x0032E06C File Offset: 0x0032C26C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D574 RID: 54644 RVA: 0x0032E0AC File Offset: 0x0032C2AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249836, XrefRangeEnd = 249841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004227 RID: 16935
			// (get) Token: 0x0600D575 RID: 54645 RVA: 0x0032E0E0 File Offset: 0x0032C2E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D576 RID: 54646 RVA: 0x00067D42 File Offset: 0x00065F42
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004223 RID: 16931
			// (get) Token: 0x0600D577 RID: 54647 RVA: 0x0032E120 File Offset: 0x0032C320
			// (set) Token: 0x0600D578 RID: 54648 RVA: 0x00067D4B File Offset: 0x00065F4B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004224 RID: 16932
			// (get) Token: 0x0600D579 RID: 54649 RVA: 0x0032E148 File Offset: 0x0032C348
			// (set) Token: 0x0600D57A RID: 54650 RVA: 0x00067D66 File Offset: 0x00065F66
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004225 RID: 16933
			// (get) Token: 0x0600D57B RID: 54651 RVA: 0x0032E178 File Offset: 0x0032C378
			// (set) Token: 0x0600D57C RID: 54652 RVA: 0x00067D85 File Offset: 0x00065F85
			public unsafe AvatarEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F94 RID: 36756
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F95 RID: 36757
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F96 RID: 36758
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F97 RID: 36759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F98 RID: 36760
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F99 RID: 36761
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F9A RID: 36762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F9B RID: 36763
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F9C RID: 36764
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
