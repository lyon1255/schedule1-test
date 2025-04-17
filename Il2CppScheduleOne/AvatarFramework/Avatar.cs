using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.AvatarFramework.Emotions;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.AvatarFramework.Impostors;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F0 RID: 1520
	public class Avatar : MonoBehaviour
	{
		// Token: 0x060084B7 RID: 33975 RVA: 0x00233824 File Offset: 0x00231A24
		// Note: this type is marked as 'beforefieldinit'.
		static Avatar()
		{
			Il2CppClassPointerStore<Avatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Avatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar>.NativeClassPtr);
			Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MAX_ACCESSORIES");
			Avatar.NativeFieldInfoPtr_USE_COMBINED_LAYERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "USE_COMBINED_LAYERS");
			Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "DEFAULT_SMOOTHNESS");
			Avatar.NativeFieldInfoPtr_maleShoulderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "maleShoulderScale");
			Avatar.NativeFieldInfoPtr_femaleShoulderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "femaleShoulderScale");
			Avatar.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Anim");
			Avatar.NativeFieldInfoPtr_LookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LookController");
			Avatar.NativeFieldInfoPtr_BodyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "BodyMeshes");
			Avatar.NativeFieldInfoPtr_ShapeKeyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "ShapeKeyMeshes");
			Avatar.NativeFieldInfoPtr_FaceMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "FaceMesh");
			Avatar.NativeFieldInfoPtr_Eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Eyes");
			Avatar.NativeFieldInfoPtr_EyeBrows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "EyeBrows");
			Avatar.NativeFieldInfoPtr_BodyContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "BodyContainer");
			Avatar.NativeFieldInfoPtr_Armature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Armature");
			Avatar.NativeFieldInfoPtr_LeftShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LeftShoulder");
			Avatar.NativeFieldInfoPtr_RightShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RightShoulder");
			Avatar.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "HeadBone");
			Avatar.NativeFieldInfoPtr_HipBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "HipBone");
			Avatar.NativeFieldInfoPtr_RagdollRBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RagdollRBs");
			Avatar.NativeFieldInfoPtr_RagdollColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RagdollColliders");
			Avatar.NativeFieldInfoPtr_MiddleSpineRB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MiddleSpineRB");
			Avatar.NativeFieldInfoPtr_EmotionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "EmotionManager");
			Avatar.NativeFieldInfoPtr_Effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Effects");
			Avatar.NativeFieldInfoPtr_MiddleSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MiddleSpine");
			Avatar.NativeFieldInfoPtr_LowerSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LowerSpine");
			Avatar.NativeFieldInfoPtr_LowestSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LowestSpine");
			Avatar.NativeFieldInfoPtr_Impostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Impostor");
			Avatar.NativeFieldInfoPtr_InitialAvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "InitialAvatarSettings");
			Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "DefaultAvatarMaterial");
			Avatar.NativeFieldInfoPtr_UseImpostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "UseImpostor");
			Avatar.NativeFieldInfoPtr_onRagdollChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "onRagdollChange");
			Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<Ragdolled>k__BackingField");
			Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<CurrentEquippable>k__BackingField");
			Avatar.NativeFieldInfoPtr_appliedGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedGender");
			Avatar.NativeFieldInfoPtr_appliedWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedWeight");
			Avatar.NativeFieldInfoPtr_appliedHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedHair");
			Avatar.NativeFieldInfoPtr_appliedHairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedHairColor");
			Avatar.NativeFieldInfoPtr_appliedAccessories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedAccessories");
			Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "wearingHairBlockingAccessory");
			Avatar.NativeFieldInfoPtr_additionalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "additionalWeight");
			Avatar.NativeFieldInfoPtr_additionalGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "additionalGender");
			Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<CurrentSettings>k__BackingField");
			Avatar.NativeFieldInfoPtr_SettingsToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "SettingsToLoad");
			Avatar.NativeFieldInfoPtr_onSettingsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "onSettingsLoaded");
			Avatar.NativeFieldInfoPtr_originalHipPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "originalHipPos");
			Avatar.NativeFieldInfoPtr_usingCombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "usingCombinedLayer");
			Avatar.NativeFieldInfoPtr_blockEyeFaceLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "blockEyeFaceLayers");
			Avatar.NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679898);
			Avatar.NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679899);
			Avatar.NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679900);
			Avatar.NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679901);
			Avatar.NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679902);
			Avatar.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679903);
			Avatar.NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679904);
			Avatar.NativeMethodInfoPtr_LoadNaked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679905);
			Avatar.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679906);
			Avatar.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679907);
			Avatar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679908);
			Avatar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679909);
			Avatar.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679910);
			Avatar.NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679911);
			Avatar.NativeMethodInfoPtr_SetEmission_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679912);
			Avatar.NativeMethodInfoPtr_IsMale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679913);
			Avatar.NativeMethodInfoPtr_IsWhite_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679914);
			Avatar.NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679915);
			Avatar.NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679916);
			Avatar.NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679917);
			Avatar.NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679918);
			Avatar.NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679919);
			Avatar.NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679920);
			Avatar.NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679921);
			Avatar.NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679922);
			Avatar.NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679923);
			Avatar.NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679924);
			Avatar.NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679925);
			Avatar.NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679926);
			Avatar.NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679927);
			Avatar.NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679928);
			Avatar.NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679929);
			Avatar.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679930);
			Avatar.NativeMethodInfoPtr_ResetHairColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679931);
			Avatar.NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679932);
			Avatar.NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679933);
			Avatar.NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679934);
			Avatar.NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679935);
			Avatar.NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679936);
			Avatar.NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679937);
			Avatar.NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679938);
			Avatar.NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679939);
			Avatar.NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679940);
			Avatar.NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679941);
			Avatar.NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679942);
			Avatar.NativeMethodInfoPtr_DestroyAccessories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679943);
			Avatar.NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679944);
			Avatar.NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679945);
			Avatar.NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679946);
			Avatar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679947);
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x060084B8 RID: 33976 RVA: 0x00233FE8 File Offset: 0x002321E8
		// (set) Token: 0x060084B9 RID: 33977 RVA: 0x00234024 File Offset: 0x00232224
		public unsafe bool Ragdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x060084BA RID: 33978 RVA: 0x00234064 File Offset: 0x00232264
		// (set) Token: 0x060084BB RID: 33979 RVA: 0x002340A4 File Offset: 0x002322A4
		public unsafe AvatarEquippable CurrentEquippable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x060084BC RID: 33980 RVA: 0x002340E8 File Offset: 0x002322E8
		// (set) Token: 0x060084BD RID: 33981 RVA: 0x00234128 File Offset: 0x00232328
		public unsafe AvatarSettings CurrentSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x0023416C File Offset: 0x0023236C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248889, XrefRangeEnd = 248890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x002341A0 File Offset: 0x002323A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248890, XrefRangeEnd = 248891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNaked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadNaked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x060084C0 RID: 33984 RVA: 0x002341D4 File Offset: 0x002323D4
		public unsafe Vector3 CenterPoint
		{
			[CallerCount(77)]
			[CachedScanResults(RefRangeStart = 248893, RefRangeEnd = 248970, XrefRangeStart = 248891, XrefRangeEnd = 248893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060084C1 RID: 33985 RVA: 0x00234210 File Offset: 0x00232410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248970, XrefRangeEnd = 248976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x0023424C File Offset: 0x0023244C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248976, XrefRangeEnd = 248981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x00234288 File Offset: 0x00232488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248981, XrefRangeEnd = 249003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x002342C4 File Offset: 0x002324C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 249007, RefRangeEnd = 249013, XrefRangeStart = 249003, XrefRangeEnd = 249007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x00234304 File Offset: 0x00232504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249013, XrefRangeEnd = 249018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMugshot(Action<Texture2D> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084C6 RID: 33990 RVA: 0x00234348 File Offset: 0x00232548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249018, XrefRangeEnd = 249026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmission(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetEmission_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x00234388 File Offset: 0x00232588
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249030, RefRangeEnd = 249034, XrefRangeStart = 249026, XrefRangeEnd = 249030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_IsMale_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x002343C4 File Offset: 0x002325C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249034, XrefRangeEnd = 249038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWhite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_IsWhite_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060084C9 RID: 33993 RVA: 0x00234400 File Offset: 0x00232600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249045, RefRangeEnd = 249046, XrefRangeStart = 249038, XrefRangeEnd = 249045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFormalAddress(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capitalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060084CA RID: 33994 RVA: 0x00234444 File Offset: 0x00232644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249053, RefRangeEnd = 249054, XrefRangeStart = 249046, XrefRangeEnd = 249053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetThirdPersonAddress(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capitalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060084CB RID: 33995 RVA: 0x00234488 File Offset: 0x00232688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249061, RefRangeEnd = 249062, XrefRangeStart = 249054, XrefRangeEnd = 249061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetThirdPersonPronoun(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capitalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x002344CC File Offset: 0x002326CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249089, RefRangeEnd = 249091, XrefRangeStart = 249062, XrefRangeEnd = 249089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShapeKeys(float gender, float weight, bool bodyOnly = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bodyOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x00234528 File Offset: 0x00232728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249091, XrefRangeEnd = 249095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFeetShrunk(bool shrink, float reduction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shrink;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reduction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084CE RID: 33998 RVA: 0x00234574 File Offset: 0x00232774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249095, XrefRangeEnd = 249099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWearingHairBlockingAccessory(bool blocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blocked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x002345B4 File Offset: 0x002327B4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 249134, RefRangeEnd = 249147, XrefRangeStart = 249099, XrefRangeEnd = 249134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x002345F8 File Offset: 0x002327F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249212, RefRangeEnd = 249215, XrefRangeStart = 249147, XrefRangeEnd = 249212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNakedSettings(AvatarSettings settings, int maxLayerOrder = 19)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLayerOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x00234648 File Offset: 0x00232848
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 249219, RefRangeEnd = 249226, XrefRangeStart = 249215, XrefRangeEnd = 249219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBodySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x0023468C File Offset: 0x0023288C
		[CallerCount(0)]
		public unsafe void SetAdditionalWeight(float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D3 RID: 34003 RVA: 0x002346CC File Offset: 0x002328CC
		[CallerCount(0)]
		public unsafe void SetAdditionalGender(float gender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D4 RID: 34004 RVA: 0x0023470C File Offset: 0x0023290C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249248, RefRangeEnd = 249249, XrefRangeStart = 249226, XrefRangeEnd = 249248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkinColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D5 RID: 34005 RVA: 0x0023474C File Offset: 0x0023294C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 249275, RefRangeEnd = 249281, XrefRangeStart = 249249, XrefRangeEnd = 249275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHairSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D6 RID: 34006 RVA: 0x00234790 File Offset: 0x00232990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249287, RefRangeEnd = 249289, XrefRangeStart = 249281, XrefRangeEnd = 249287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHairVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x002347D0 File Offset: 0x002329D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 249297, RefRangeEnd = 249302, XrefRangeStart = 249289, XrefRangeEnd = 249297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHairColorSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D8 RID: 34008 RVA: 0x00234814 File Offset: 0x00232A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249302, XrefRangeEnd = 249316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideHairColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D9 RID: 34009 RVA: 0x00234854 File Offset: 0x00232A54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249330, RefRangeEnd = 249331, XrefRangeStart = 249316, XrefRangeEnd = 249330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHairColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ResetHairColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x00234888 File Offset: 0x00232A88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249335, RefRangeEnd = 249339, XrefRangeStart = 249331, XrefRangeEnd = 249335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeBallSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x002348CC File Offset: 0x00232ACC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249341, RefRangeEnd = 249345, XrefRangeStart = 249339, XrefRangeEnd = 249341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeLidSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x00234910 File Offset: 0x00232B10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249353, RefRangeEnd = 249357, XrefRangeStart = 249345, XrefRangeEnd = 249353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeLidColorSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x00234954 File Offset: 0x00232B54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249359, RefRangeEnd = 249363, XrefRangeStart = 249357, XrefRangeEnd = 249359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyebrowSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DE RID: 34014 RVA: 0x00234998 File Offset: 0x00232B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249368, RefRangeEnd = 249369, XrefRangeStart = 249363, XrefRangeEnd = 249368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlockEyeFaceLayers(bool block)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DF RID: 34015 RVA: 0x002349D8 File Offset: 0x00232BD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 249465, RefRangeEnd = 249472, XrefRangeStart = 249369, XrefRangeEnd = 249465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFaceLayerSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E0 RID: 34016 RVA: 0x00234A1C File Offset: 0x00232C1C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 249500, RefRangeEnd = 249508, XrefRangeStart = 249472, XrefRangeEnd = 249500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceLayer(int index, string assetPath, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E1 RID: 34017 RVA: 0x00234A7C File Offset: 0x00232C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249508, XrefRangeEnd = 249523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceTexture(Texture2D tex, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x00234ACC File Offset: 0x00232CCC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 249608, RefRangeEnd = 249615, XrefRangeStart = 249523, XrefRangeEnd = 249608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBodyLayerSettings(AvatarSettings settings, int maxOrder = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x00234B1C File Offset: 0x00232D1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249665, RefRangeEnd = 249667, XrefRangeStart = 249615, XrefRangeEnd = 249665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBodyLayer(int index, string assetPath, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E4 RID: 34020 RVA: 0x00234B7C File Offset: 0x00232D7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249743, RefRangeEnd = 249746, XrefRangeStart = 249667, XrefRangeEnd = 249743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAccessorySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E5 RID: 34021 RVA: 0x00234BC0 File Offset: 0x00232DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249746, XrefRangeEnd = 249755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyAccessories()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_DestroyAccessories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E6 RID: 34022 RVA: 0x00234BF4 File Offset: 0x00232DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249755, XrefRangeEnd = 249776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRagdollPhysicsEnabled(bool ragdollEnabled, bool playStandUpAnim = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ragdollEnabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E7 RID: 34023 RVA: 0x00234C4C File Offset: 0x00232E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249776, XrefRangeEnd = 249800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AvatarEquippable SetEquippable(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x060084E8 RID: 34024 RVA: 0x00234CA8 File Offset: 0x00232EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249800, XrefRangeEnd = 249810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveEquippableMessage(string message, Il2CppSystem.Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E9 RID: 34025 RVA: 0x00234D08 File Offset: 0x00232F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249810, XrefRangeEnd = 249817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Avatar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x0003EF05 File Offset: 0x0003D105
		public Avatar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x060084EB RID: 34027 RVA: 0x00234D44 File Offset: 0x00232F44
		// (set) Token: 0x060084EC RID: 34028 RVA: 0x0003EF0E File Offset: 0x0003D10E
		public unsafe static int MAX_ACCESSORIES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES, (void*)(&value));
			}
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x060084ED RID: 34029 RVA: 0x00234D60 File Offset: 0x00232F60
		// (set) Token: 0x060084EE RID: 34030 RVA: 0x0003EF1C File Offset: 0x0003D11C
		public unsafe static bool USE_COMBINED_LAYERS
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_USE_COMBINED_LAYERS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_USE_COMBINED_LAYERS, (void*)(&value));
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x060084EF RID: 34031 RVA: 0x00234D7C File Offset: 0x00232F7C
		// (set) Token: 0x060084F0 RID: 34032 RVA: 0x0003EF2A File Offset: 0x0003D12A
		public unsafe static float DEFAULT_SMOOTHNESS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS, (void*)(&value));
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x060084F1 RID: 34033 RVA: 0x00234D98 File Offset: 0x00232F98
		// (set) Token: 0x060084F2 RID: 34034 RVA: 0x0003EF38 File Offset: 0x0003D138
		public unsafe static float maleShoulderScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_maleShoulderScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_maleShoulderScale, (void*)(&value));
			}
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x060084F3 RID: 34035 RVA: 0x00234DB4 File Offset: 0x00232FB4
		// (set) Token: 0x060084F4 RID: 34036 RVA: 0x0003EF46 File Offset: 0x0003D146
		public unsafe static float femaleShoulderScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_femaleShoulderScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_femaleShoulderScale, (void*)(&value));
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x060084F5 RID: 34037 RVA: 0x00234DD0 File Offset: 0x00232FD0
		// (set) Token: 0x060084F6 RID: 34038 RVA: 0x0003EF54 File Offset: 0x0003D154
		public unsafe AvatarAnimation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x060084F7 RID: 34039 RVA: 0x00234E00 File Offset: 0x00233000
		// (set) Token: 0x060084F8 RID: 34040 RVA: 0x0003EF73 File Offset: 0x0003D173
		public unsafe AvatarLookController LookController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LookController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarLookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LookController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x060084F9 RID: 34041 RVA: 0x00234E30 File Offset: 0x00233030
		// (set) Token: 0x060084FA RID: 34042 RVA: 0x0003EF92 File Offset: 0x0003D192
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> BodyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x060084FB RID: 34043 RVA: 0x00234E60 File Offset: 0x00233060
		// (set) Token: 0x060084FC RID: 34044 RVA: 0x0003EFB1 File Offset: 0x0003D1B1
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> ShapeKeyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ShapeKeyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ShapeKeyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x060084FD RID: 34045 RVA: 0x00234E90 File Offset: 0x00233090
		// (set) Token: 0x060084FE RID: 34046 RVA: 0x0003EFD0 File Offset: 0x0003D1D0
		public unsafe SkinnedMeshRenderer FaceMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FaceMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FaceMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x060084FF RID: 34047 RVA: 0x00234EC0 File Offset: 0x002330C0
		// (set) Token: 0x06008500 RID: 34048 RVA: 0x0003EFEF File Offset: 0x0003D1EF
		public unsafe EyeController Eyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Eyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x06008501 RID: 34049 RVA: 0x00234EF0 File Offset: 0x002330F0
		// (set) Token: 0x06008502 RID: 34050 RVA: 0x0003F00E File Offset: 0x0003D20E
		public unsafe EyebrowController EyeBrows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EyeBrows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyebrowController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EyeBrows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x06008503 RID: 34051 RVA: 0x00234F20 File Offset: 0x00233120
		// (set) Token: 0x06008504 RID: 34052 RVA: 0x0003F02D File Offset: 0x0003D22D
		public unsafe Transform BodyContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x06008505 RID: 34053 RVA: 0x00234F50 File Offset: 0x00233150
		// (set) Token: 0x06008506 RID: 34054 RVA: 0x0003F04C File Offset: 0x0003D24C
		public unsafe Transform Armature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Armature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Armature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x06008507 RID: 34055 RVA: 0x00234F80 File Offset: 0x00233180
		// (set) Token: 0x06008508 RID: 34056 RVA: 0x0003F06B File Offset: 0x0003D26B
		public unsafe Transform LeftShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x06008509 RID: 34057 RVA: 0x00234FB0 File Offset: 0x002331B0
		// (set) Token: 0x0600850A RID: 34058 RVA: 0x0003F08A File Offset: 0x0003D28A
		public unsafe Transform RightShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x0600850B RID: 34059 RVA: 0x00234FE0 File Offset: 0x002331E0
		// (set) Token: 0x0600850C RID: 34060 RVA: 0x0003F0A9 File Offset: 0x0003D2A9
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x00235010 File Offset: 0x00233210
		// (set) Token: 0x0600850E RID: 34062 RVA: 0x0003F0C8 File Offset: 0x0003D2C8
		public unsafe Transform HipBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HipBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HipBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x0600850F RID: 34063 RVA: 0x00235040 File Offset: 0x00233240
		// (set) Token: 0x06008510 RID: 34064 RVA: 0x0003F0E7 File Offset: 0x0003D2E7
		public unsafe Il2CppReferenceArray<Rigidbody> RagdollRBs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollRBs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollRBs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x06008511 RID: 34065 RVA: 0x00235070 File Offset: 0x00233270
		// (set) Token: 0x06008512 RID: 34066 RVA: 0x0003F106 File Offset: 0x0003D306
		public unsafe Il2CppReferenceArray<Collider> RagdollColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x06008513 RID: 34067 RVA: 0x002350A0 File Offset: 0x002332A0
		// (set) Token: 0x06008514 RID: 34068 RVA: 0x0003F125 File Offset: 0x0003D325
		public unsafe Rigidbody MiddleSpineRB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpineRB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpineRB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x06008515 RID: 34069 RVA: 0x002350D0 File Offset: 0x002332D0
		// (set) Token: 0x06008516 RID: 34070 RVA: 0x0003F144 File Offset: 0x0003D344
		public unsafe AvatarEmotionManager EmotionManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EmotionManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EmotionManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x06008517 RID: 34071 RVA: 0x00235100 File Offset: 0x00233300
		// (set) Token: 0x06008518 RID: 34072 RVA: 0x0003F163 File Offset: 0x0003D363
		public unsafe AvatarEffects Effects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Effects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Effects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x06008519 RID: 34073 RVA: 0x00235130 File Offset: 0x00233330
		// (set) Token: 0x0600851A RID: 34074 RVA: 0x0003F182 File Offset: 0x0003D382
		public unsafe Transform MiddleSpine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x0600851B RID: 34075 RVA: 0x00235160 File Offset: 0x00233360
		// (set) Token: 0x0600851C RID: 34076 RVA: 0x0003F1A1 File Offset: 0x0003D3A1
		public unsafe Transform LowerSpine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowerSpine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowerSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x0600851D RID: 34077 RVA: 0x00235190 File Offset: 0x00233390
		// (set) Token: 0x0600851E RID: 34078 RVA: 0x0003F1C0 File Offset: 0x0003D3C0
		public unsafe Transform LowestSpine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowestSpine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowestSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x0600851F RID: 34079 RVA: 0x002351C0 File Offset: 0x002333C0
		// (set) Token: 0x06008520 RID: 34080 RVA: 0x0003F1DF File Offset: 0x0003D3DF
		public unsafe AvatarImpostor Impostor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Impostor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarImpostor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Impostor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x06008521 RID: 34081 RVA: 0x002351F0 File Offset: 0x002333F0
		// (set) Token: 0x06008522 RID: 34082 RVA: 0x0003F1FE File Offset: 0x0003D3FE
		public unsafe AvatarSettings InitialAvatarSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_InitialAvatarSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_InitialAvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x06008523 RID: 34083 RVA: 0x00235220 File Offset: 0x00233420
		// (set) Token: 0x06008524 RID: 34084 RVA: 0x0003F21D File Offset: 0x0003D41D
		public unsafe Material DefaultAvatarMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x06008525 RID: 34085 RVA: 0x00235250 File Offset: 0x00233450
		// (set) Token: 0x06008526 RID: 34086 RVA: 0x0003F23C File Offset: 0x0003D43C
		public unsafe bool UseImpostor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_UseImpostor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_UseImpostor)) = value;
			}
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x06008527 RID: 34087 RVA: 0x00235278 File Offset: 0x00233478
		// (set) Token: 0x06008528 RID: 34088 RVA: 0x0003F257 File Offset: 0x0003D457
		public unsafe UnityEvent<bool, bool, bool> onRagdollChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onRagdollChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool, bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onRagdollChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x06008529 RID: 34089 RVA: 0x002352A8 File Offset: 0x002334A8
		// (set) Token: 0x0600852A RID: 34090 RVA: 0x0003F276 File Offset: 0x0003D476
		public unsafe bool _Ragdolled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x0600852B RID: 34091 RVA: 0x002352D0 File Offset: 0x002334D0
		// (set) Token: 0x0600852C RID: 34092 RVA: 0x0003F291 File Offset: 0x0003D491
		public unsafe AvatarEquippable _CurrentEquippable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x0600852D RID: 34093 RVA: 0x00235300 File Offset: 0x00233500
		// (set) Token: 0x0600852E RID: 34094 RVA: 0x0003F2B0 File Offset: 0x0003D4B0
		public unsafe float appliedGender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedGender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedGender)) = value;
			}
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x0600852F RID: 34095 RVA: 0x00235328 File Offset: 0x00233528
		// (set) Token: 0x06008530 RID: 34096 RVA: 0x0003F2CB File Offset: 0x0003D4CB
		public unsafe float appliedWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedWeight)) = value;
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x06008531 RID: 34097 RVA: 0x00235350 File Offset: 0x00233550
		// (set) Token: 0x06008532 RID: 34098 RVA: 0x0003F2E6 File Offset: 0x0003D4E6
		public unsafe Hair appliedHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hair>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x06008533 RID: 34099 RVA: 0x00235380 File Offset: 0x00233580
		// (set) Token: 0x06008534 RID: 34100 RVA: 0x0003F305 File Offset: 0x0003D505
		public unsafe Color appliedHairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHairColor)) = value;
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x06008535 RID: 34101 RVA: 0x002353A8 File Offset: 0x002335A8
		// (set) Token: 0x06008536 RID: 34102 RVA: 0x0003F320 File Offset: 0x0003D520
		public unsafe Il2CppReferenceArray<Accessory> appliedAccessories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedAccessories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Accessory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedAccessories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x06008537 RID: 34103 RVA: 0x002353D8 File Offset: 0x002335D8
		// (set) Token: 0x06008538 RID: 34104 RVA: 0x0003F33F File Offset: 0x0003D53F
		public unsafe bool wearingHairBlockingAccessory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory)) = value;
			}
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x06008539 RID: 34105 RVA: 0x00235400 File Offset: 0x00233600
		// (set) Token: 0x0600853A RID: 34106 RVA: 0x0003F35A File Offset: 0x0003D55A
		public unsafe float additionalWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalWeight)) = value;
			}
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x0600853B RID: 34107 RVA: 0x00235428 File Offset: 0x00233628
		// (set) Token: 0x0600853C RID: 34108 RVA: 0x0003F375 File Offset: 0x0003D575
		public unsafe float additionalGender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalGender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalGender)) = value;
			}
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x0600853D RID: 34109 RVA: 0x00235450 File Offset: 0x00233650
		// (set) Token: 0x0600853E RID: 34110 RVA: 0x0003F390 File Offset: 0x0003D590
		public unsafe AvatarSettings _CurrentSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x0600853F RID: 34111 RVA: 0x00235480 File Offset: 0x00233680
		// (set) Token: 0x06008540 RID: 34112 RVA: 0x0003F3AF File Offset: 0x0003D5AF
		public unsafe AvatarSettings SettingsToLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_SettingsToLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_SettingsToLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x06008541 RID: 34113 RVA: 0x002354B0 File Offset: 0x002336B0
		// (set) Token: 0x06008542 RID: 34114 RVA: 0x0003F3CE File Offset: 0x0003D5CE
		public unsafe UnityEvent onSettingsLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onSettingsLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onSettingsLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x06008543 RID: 34115 RVA: 0x002354E0 File Offset: 0x002336E0
		// (set) Token: 0x06008544 RID: 34116 RVA: 0x0003F3ED File Offset: 0x0003D5ED
		public unsafe Vector3 originalHipPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_originalHipPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_originalHipPos)) = value;
			}
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x06008545 RID: 34117 RVA: 0x00235508 File Offset: 0x00233708
		// (set) Token: 0x06008546 RID: 34118 RVA: 0x0003F408 File Offset: 0x0003D608
		public unsafe bool usingCombinedLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_usingCombinedLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_usingCombinedLayer)) = value;
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x06008547 RID: 34119 RVA: 0x00235530 File Offset: 0x00233730
		// (set) Token: 0x06008548 RID: 34120 RVA: 0x0003F423 File Offset: 0x0003D623
		public unsafe bool blockEyeFaceLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_blockEyeFaceLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_blockEyeFaceLayers)) = value;
			}
		}

		// Token: 0x04005A5E RID: 23134
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ACCESSORIES;

		// Token: 0x04005A5F RID: 23135
		private static readonly IntPtr NativeFieldInfoPtr_USE_COMBINED_LAYERS;

		// Token: 0x04005A60 RID: 23136
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SMOOTHNESS;

		// Token: 0x04005A61 RID: 23137
		private static readonly IntPtr NativeFieldInfoPtr_maleShoulderScale;

		// Token: 0x04005A62 RID: 23138
		private static readonly IntPtr NativeFieldInfoPtr_femaleShoulderScale;

		// Token: 0x04005A63 RID: 23139
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005A64 RID: 23140
		private static readonly IntPtr NativeFieldInfoPtr_LookController;

		// Token: 0x04005A65 RID: 23141
		private static readonly IntPtr NativeFieldInfoPtr_BodyMeshes;

		// Token: 0x04005A66 RID: 23142
		private static readonly IntPtr NativeFieldInfoPtr_ShapeKeyMeshes;

		// Token: 0x04005A67 RID: 23143
		private static readonly IntPtr NativeFieldInfoPtr_FaceMesh;

		// Token: 0x04005A68 RID: 23144
		private static readonly IntPtr NativeFieldInfoPtr_Eyes;

		// Token: 0x04005A69 RID: 23145
		private static readonly IntPtr NativeFieldInfoPtr_EyeBrows;

		// Token: 0x04005A6A RID: 23146
		private static readonly IntPtr NativeFieldInfoPtr_BodyContainer;

		// Token: 0x04005A6B RID: 23147
		private static readonly IntPtr NativeFieldInfoPtr_Armature;

		// Token: 0x04005A6C RID: 23148
		private static readonly IntPtr NativeFieldInfoPtr_LeftShoulder;

		// Token: 0x04005A6D RID: 23149
		private static readonly IntPtr NativeFieldInfoPtr_RightShoulder;

		// Token: 0x04005A6E RID: 23150
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04005A6F RID: 23151
		private static readonly IntPtr NativeFieldInfoPtr_HipBone;

		// Token: 0x04005A70 RID: 23152
		private static readonly IntPtr NativeFieldInfoPtr_RagdollRBs;

		// Token: 0x04005A71 RID: 23153
		private static readonly IntPtr NativeFieldInfoPtr_RagdollColliders;

		// Token: 0x04005A72 RID: 23154
		private static readonly IntPtr NativeFieldInfoPtr_MiddleSpineRB;

		// Token: 0x04005A73 RID: 23155
		private static readonly IntPtr NativeFieldInfoPtr_EmotionManager;

		// Token: 0x04005A74 RID: 23156
		private static readonly IntPtr NativeFieldInfoPtr_Effects;

		// Token: 0x04005A75 RID: 23157
		private static readonly IntPtr NativeFieldInfoPtr_MiddleSpine;

		// Token: 0x04005A76 RID: 23158
		private static readonly IntPtr NativeFieldInfoPtr_LowerSpine;

		// Token: 0x04005A77 RID: 23159
		private static readonly IntPtr NativeFieldInfoPtr_LowestSpine;

		// Token: 0x04005A78 RID: 23160
		private static readonly IntPtr NativeFieldInfoPtr_Impostor;

		// Token: 0x04005A79 RID: 23161
		private static readonly IntPtr NativeFieldInfoPtr_InitialAvatarSettings;

		// Token: 0x04005A7A RID: 23162
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAvatarMaterial;

		// Token: 0x04005A7B RID: 23163
		private static readonly IntPtr NativeFieldInfoPtr_UseImpostor;

		// Token: 0x04005A7C RID: 23164
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollChange;

		// Token: 0x04005A7D RID: 23165
		private static readonly IntPtr NativeFieldInfoPtr__Ragdolled_k__BackingField;

		// Token: 0x04005A7E RID: 23166
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEquippable_k__BackingField;

		// Token: 0x04005A7F RID: 23167
		private static readonly IntPtr NativeFieldInfoPtr_appliedGender;

		// Token: 0x04005A80 RID: 23168
		private static readonly IntPtr NativeFieldInfoPtr_appliedWeight;

		// Token: 0x04005A81 RID: 23169
		private static readonly IntPtr NativeFieldInfoPtr_appliedHair;

		// Token: 0x04005A82 RID: 23170
		private static readonly IntPtr NativeFieldInfoPtr_appliedHairColor;

		// Token: 0x04005A83 RID: 23171
		private static readonly IntPtr NativeFieldInfoPtr_appliedAccessories;

		// Token: 0x04005A84 RID: 23172
		private static readonly IntPtr NativeFieldInfoPtr_wearingHairBlockingAccessory;

		// Token: 0x04005A85 RID: 23173
		private static readonly IntPtr NativeFieldInfoPtr_additionalWeight;

		// Token: 0x04005A86 RID: 23174
		private static readonly IntPtr NativeFieldInfoPtr_additionalGender;

		// Token: 0x04005A87 RID: 23175
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSettings_k__BackingField;

		// Token: 0x04005A88 RID: 23176
		private static readonly IntPtr NativeFieldInfoPtr_SettingsToLoad;

		// Token: 0x04005A89 RID: 23177
		private static readonly IntPtr NativeFieldInfoPtr_onSettingsLoaded;

		// Token: 0x04005A8A RID: 23178
		private static readonly IntPtr NativeFieldInfoPtr_originalHipPos;

		// Token: 0x04005A8B RID: 23179
		private static readonly IntPtr NativeFieldInfoPtr_usingCombinedLayer;

		// Token: 0x04005A8C RID: 23180
		private static readonly IntPtr NativeFieldInfoPtr_blockEyeFaceLayers;

		// Token: 0x04005A8D RID: 23181
		private static readonly IntPtr NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0;

		// Token: 0x04005A8E RID: 23182
		private static readonly IntPtr NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0;

		// Token: 0x04005A8F RID: 23183
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0;

		// Token: 0x04005A90 RID: 23184
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0;

		// Token: 0x04005A91 RID: 23185
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0;

		// Token: 0x04005A92 RID: 23186
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0;

		// Token: 0x04005A93 RID: 23187
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

		// Token: 0x04005A94 RID: 23188
		private static readonly IntPtr NativeMethodInfoPtr_LoadNaked_Public_Void_0;

		// Token: 0x04005A95 RID: 23189
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0;

		// Token: 0x04005A96 RID: 23190
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005A97 RID: 23191
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005A98 RID: 23192
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04005A99 RID: 23193
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04005A9A RID: 23194
		private static readonly IntPtr NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0;

		// Token: 0x04005A9B RID: 23195
		private static readonly IntPtr NativeMethodInfoPtr_SetEmission_Public_Void_Color_0;

		// Token: 0x04005A9C RID: 23196
		private static readonly IntPtr NativeMethodInfoPtr_IsMale_Public_Boolean_0;

		// Token: 0x04005A9D RID: 23197
		private static readonly IntPtr NativeMethodInfoPtr_IsWhite_Public_Boolean_0;

		// Token: 0x04005A9E RID: 23198
		private static readonly IntPtr NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0;

		// Token: 0x04005A9F RID: 23199
		private static readonly IntPtr NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0;

		// Token: 0x04005AA0 RID: 23200
		private static readonly IntPtr NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0;

		// Token: 0x04005AA1 RID: 23201
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_Boolean_0;

		// Token: 0x04005AA2 RID: 23202
		private static readonly IntPtr NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0;

		// Token: 0x04005AA3 RID: 23203
		private static readonly IntPtr NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0;

		// Token: 0x04005AA4 RID: 23204
		private static readonly IntPtr NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AA5 RID: 23205
		private static readonly IntPtr NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Int32_0;

		// Token: 0x04005AA6 RID: 23206
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AA7 RID: 23207
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0;

		// Token: 0x04005AA8 RID: 23208
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0;

		// Token: 0x04005AA9 RID: 23209
		private static readonly IntPtr NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0;

		// Token: 0x04005AAA RID: 23210
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AAB RID: 23211
		private static readonly IntPtr NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0;

		// Token: 0x04005AAC RID: 23212
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AAD RID: 23213
		private static readonly IntPtr NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0;

		// Token: 0x04005AAE RID: 23214
		private static readonly IntPtr NativeMethodInfoPtr_ResetHairColor_Public_Void_0;

		// Token: 0x04005AAF RID: 23215
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AB0 RID: 23216
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AB1 RID: 23217
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AB2 RID: 23218
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AB3 RID: 23219
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0;

		// Token: 0x04005AB4 RID: 23220
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AB5 RID: 23221
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0;

		// Token: 0x04005AB6 RID: 23222
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0;

		// Token: 0x04005AB7 RID: 23223
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0;

		// Token: 0x04005AB8 RID: 23224
		private static readonly IntPtr NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0;

		// Token: 0x04005AB9 RID: 23225
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005ABA RID: 23226
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAccessories_Private_Void_0;

		// Token: 0x04005ABB RID: 23227
		private static readonly IntPtr NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Public_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x04005ABC RID: 23228
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0;

		// Token: 0x04005ABD RID: 23229
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04005ABE RID: 23230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AE9 RID: 2793
		[ObfuscatedName("ScheduleOne.AvatarFramework.Avatar+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D556 RID: 54614 RVA: 0x0032D9E8 File Offset: 0x0032BBE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr);
				Avatar.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9");
				Avatar.__c.NativeFieldInfoPtr___9__90_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9__90_0");
				Avatar.__c.NativeFieldInfoPtr___9__93_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9__93_0");
				Avatar.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100679950);
				Avatar.__c.NativeMethodInfoPtr__ApplyFaceLayerSettings_b__90_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100679951);
				Avatar.__c.NativeMethodInfoPtr__ApplyBodyLayerSettings_b__93_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100679952);
			}

			// Token: 0x0600D557 RID: 54615 RVA: 0x0032DA8C File Offset: 0x0032BC8C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D558 RID: 54616 RVA: 0x0032DAC8 File Offset: 0x0032BCC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248883, XrefRangeEnd = 248886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ApplyFaceLayerSettings_b__90_0(Tuple<FaceLayer, Color> x, Tuple<FaceLayer, Color> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ApplyFaceLayerSettings_b__90_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D559 RID: 54617 RVA: 0x0032DB28 File Offset: 0x0032BD28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248886, XrefRangeEnd = 248889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ApplyBodyLayerSettings_b__93_0(Tuple<AvatarLayer, Color> x, Tuple<AvatarLayer, Color> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ApplyBodyLayerSettings_b__93_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D55A RID: 54618 RVA: 0x00067CA1 File Offset: 0x00065EA1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700421B RID: 16923
			// (get) Token: 0x0600D55B RID: 54619 RVA: 0x0032DB88 File Offset: 0x0032BD88
			// (set) Token: 0x0600D55C RID: 54620 RVA: 0x00067CAA File Offset: 0x00065EAA
			public unsafe static Avatar.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421C RID: 16924
			// (get) Token: 0x0600D55D RID: 54621 RVA: 0x0032DBB0 File Offset: 0x0032BDB0
			// (set) Token: 0x0600D55E RID: 54622 RVA: 0x00067CBC File Offset: 0x00065EBC
			public unsafe static Comparison<Tuple<FaceLayer, Color>> __9__90_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9__90_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Tuple<FaceLayer, Color>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9__90_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421D RID: 16925
			// (get) Token: 0x0600D55F RID: 54623 RVA: 0x0032DBD8 File Offset: 0x0032BDD8
			// (set) Token: 0x0600D560 RID: 54624 RVA: 0x00067CCE File Offset: 0x00065ECE
			public unsafe static Comparison<Tuple<AvatarLayer, Color>> __9__93_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9__93_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Tuple<AvatarLayer, Color>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9__93_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F85 RID: 36741
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F86 RID: 36742
			private static readonly IntPtr NativeFieldInfoPtr___9__90_0;

			// Token: 0x04008F87 RID: 36743
			private static readonly IntPtr NativeFieldInfoPtr___9__93_0;

			// Token: 0x04008F88 RID: 36744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F89 RID: 36745
			private static readonly IntPtr NativeMethodInfoPtr__ApplyFaceLayerSettings_b__90_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0;

			// Token: 0x04008F8A RID: 36746
			private static readonly IntPtr NativeMethodInfoPtr__ApplyBodyLayerSettings_b__93_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0;
		}
	}
}
