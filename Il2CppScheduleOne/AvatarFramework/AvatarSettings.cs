using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F3 RID: 1523
	[Serializable]
	public class AvatarSettings : ScriptableObject
	{
		// Token: 0x060085C0 RID: 34240 RVA: 0x00236CDC File Offset: 0x00234EDC
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSettings()
		{
			Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr);
			AvatarSettings.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "SkinColor");
			AvatarSettings.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Height");
			AvatarSettings.NativeFieldInfoPtr_Gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Gender");
			AvatarSettings.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Weight");
			AvatarSettings.NativeFieldInfoPtr_HairPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "HairPath");
			AvatarSettings.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "HairColor");
			AvatarSettings.NativeFieldInfoPtr_EyebrowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowScale");
			AvatarSettings.NativeFieldInfoPtr_EyebrowThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowThickness");
			AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowRestingHeight");
			AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowRestingAngle");
			AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LeftEyeLidColor");
			AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "RightEyeLidColor");
			AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LeftEyeRestingState");
			AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "RightEyeRestingState");
			AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyeballMaterialIdentifier");
			AvatarSettings.NativeFieldInfoPtr_EyeBallTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyeBallTint");
			AvatarSettings.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "PupilDilation");
			AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "FaceLayerSettings");
			AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "BodyLayerSettings");
			AvatarSettings.NativeFieldInfoPtr_AccessorySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "AccessorySettings");
			AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "UseCombinedLayer");
			AvatarSettings.NativeFieldInfoPtr_CombinedLayerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "CombinedLayerPath");
			AvatarSettings.NativeFieldInfoPtr_ImpostorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "ImpostorTexture");
			AvatarSettings.NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680002);
			AvatarSettings.NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680003);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680004);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680005);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680006);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680007);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680008);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680009);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680010);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680011);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680012);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680013);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680014);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680015);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680016);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680017);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680018);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680019);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680020);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680021);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680022);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680023);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680024);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680025);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680026);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680027);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680028);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680029);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680030);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680031);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680032);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680033);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680034);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680035);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680036);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680037);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680038);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680039);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680040);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680041);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680042);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680043);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680044);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680045);
			AvatarSettings.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680046);
			AvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680047);
			AvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680048);
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x060085C1 RID: 34241 RVA: 0x00237284 File Offset: 0x00235484
		public unsafe float UpperEyelidRestingPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x060085C2 RID: 34242 RVA: 0x002372C0 File Offset: 0x002354C0
		public unsafe float LowerEyelidRestingPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x060085C3 RID: 34243 RVA: 0x002372FC File Offset: 0x002354FC
		public unsafe string FaceLayer1Path
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 250267, RefRangeEnd = 250269, XrefRangeStart = 250263, XrefRangeEnd = 250267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x060085C4 RID: 34244 RVA: 0x00237334 File Offset: 0x00235534
		public unsafe Color FaceLayer1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250269, XrefRangeEnd = 250273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x060085C5 RID: 34245 RVA: 0x00237370 File Offset: 0x00235570
		public unsafe string FaceLayer2Path
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 250277, RefRangeEnd = 250281, XrefRangeStart = 250273, XrefRangeEnd = 250277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x060085C6 RID: 34246 RVA: 0x002373A8 File Offset: 0x002355A8
		public unsafe Color FaceLayer2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250281, XrefRangeEnd = 250285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x060085C7 RID: 34247 RVA: 0x002373E4 File Offset: 0x002355E4
		public unsafe string FaceLayer3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250285, XrefRangeEnd = 250289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x060085C8 RID: 34248 RVA: 0x0023741C File Offset: 0x0023561C
		public unsafe Color FaceLayer3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250289, XrefRangeEnd = 250293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x060085C9 RID: 34249 RVA: 0x00237458 File Offset: 0x00235658
		public unsafe string FaceLayer4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250293, XrefRangeEnd = 250297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x060085CA RID: 34250 RVA: 0x00237490 File Offset: 0x00235690
		public unsafe Color FaceLayer4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250297, XrefRangeEnd = 250301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x060085CB RID: 34251 RVA: 0x002374CC File Offset: 0x002356CC
		public unsafe string FaceLayer5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250301, XrefRangeEnd = 250305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x060085CC RID: 34252 RVA: 0x00237504 File Offset: 0x00235704
		public unsafe Color FaceLayer5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250305, XrefRangeEnd = 250309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x060085CD RID: 34253 RVA: 0x00237540 File Offset: 0x00235740
		public unsafe string FaceLayer6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250309, XrefRangeEnd = 250313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x060085CE RID: 34254 RVA: 0x00237578 File Offset: 0x00235778
		public unsafe Color FaceLayer6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250313, XrefRangeEnd = 250317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x060085CF RID: 34255 RVA: 0x002375B4 File Offset: 0x002357B4
		public unsafe string BodyLayer1Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250317, XrefRangeEnd = 250321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x060085D0 RID: 34256 RVA: 0x002375EC File Offset: 0x002357EC
		public unsafe Color BodyLayer1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250321, XrefRangeEnd = 250325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x060085D1 RID: 34257 RVA: 0x00237628 File Offset: 0x00235828
		public unsafe string BodyLayer2Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250325, XrefRangeEnd = 250329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x060085D2 RID: 34258 RVA: 0x00237660 File Offset: 0x00235860
		public unsafe Color BodyLayer2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250329, XrefRangeEnd = 250333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x060085D3 RID: 34259 RVA: 0x0023769C File Offset: 0x0023589C
		public unsafe string BodyLayer3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250333, XrefRangeEnd = 250337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x060085D4 RID: 34260 RVA: 0x002376D4 File Offset: 0x002358D4
		public unsafe Color BodyLayer3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250337, XrefRangeEnd = 250341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x060085D5 RID: 34261 RVA: 0x00237710 File Offset: 0x00235910
		public unsafe string BodyLayer4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250341, XrefRangeEnd = 250345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x060085D6 RID: 34262 RVA: 0x00237748 File Offset: 0x00235948
		public unsafe Color BodyLayer4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250345, XrefRangeEnd = 250349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x060085D7 RID: 34263 RVA: 0x00237784 File Offset: 0x00235984
		public unsafe string BodyLayer5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250349, XrefRangeEnd = 250353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x060085D8 RID: 34264 RVA: 0x002377BC File Offset: 0x002359BC
		public unsafe Color BodyLayer5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250353, XrefRangeEnd = 250357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x060085D9 RID: 34265 RVA: 0x002377F8 File Offset: 0x002359F8
		public unsafe string BodyLayer6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250357, XrefRangeEnd = 250361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x060085DA RID: 34266 RVA: 0x00237830 File Offset: 0x00235A30
		public unsafe Color BodyLayer6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250361, XrefRangeEnd = 250365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x060085DB RID: 34267 RVA: 0x0023786C File Offset: 0x00235A6C
		public unsafe string Accessory1Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250365, XrefRangeEnd = 250369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x060085DC RID: 34268 RVA: 0x002378A4 File Offset: 0x00235AA4
		public unsafe Color Accessory1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250369, XrefRangeEnd = 250373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x002378E0 File Offset: 0x00235AE0
		public unsafe string Accessory2Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250373, XrefRangeEnd = 250377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x060085DE RID: 34270 RVA: 0x00237918 File Offset: 0x00235B18
		public unsafe Color Accessory2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250377, XrefRangeEnd = 250381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x060085DF RID: 34271 RVA: 0x00237954 File Offset: 0x00235B54
		public unsafe string Accessory3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250381, XrefRangeEnd = 250385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x060085E0 RID: 34272 RVA: 0x0023798C File Offset: 0x00235B8C
		public unsafe Color Accessory3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250385, XrefRangeEnd = 250389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x060085E1 RID: 34273 RVA: 0x002379C8 File Offset: 0x00235BC8
		public unsafe string Accessory4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250389, XrefRangeEnd = 250393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x060085E2 RID: 34274 RVA: 0x00237A00 File Offset: 0x00235C00
		public unsafe Color Accessory4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250393, XrefRangeEnd = 250397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x060085E3 RID: 34275 RVA: 0x00237A3C File Offset: 0x00235C3C
		public unsafe string Accessory5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250397, XrefRangeEnd = 250401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x060085E4 RID: 34276 RVA: 0x00237A74 File Offset: 0x00235C74
		public unsafe Color Accessory5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250401, XrefRangeEnd = 250405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x060085E5 RID: 34277 RVA: 0x00237AB0 File Offset: 0x00235CB0
		public unsafe string Accessory6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250405, XrefRangeEnd = 250409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x060085E6 RID: 34278 RVA: 0x00237AE8 File Offset: 0x00235CE8
		public unsafe Color Accessory6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250409, XrefRangeEnd = 250413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x060085E7 RID: 34279 RVA: 0x00237B24 File Offset: 0x00235D24
		public unsafe string Accessory7Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250413, XrefRangeEnd = 250417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x060085E8 RID: 34280 RVA: 0x00237B5C File Offset: 0x00235D5C
		public unsafe Color Accessory7Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250417, XrefRangeEnd = 250421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x060085E9 RID: 34281 RVA: 0x00237B98 File Offset: 0x00235D98
		public unsafe string Accessory8Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250421, XrefRangeEnd = 250425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x060085EA RID: 34282 RVA: 0x00237BD0 File Offset: 0x00235DD0
		public unsafe Color Accessory8Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250425, XrefRangeEnd = 250429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x060085EB RID: 34283 RVA: 0x00237C0C File Offset: 0x00235E0C
		public unsafe string Accessory9Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250429, XrefRangeEnd = 250433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x060085EC RID: 34284 RVA: 0x00237C44 File Offset: 0x00235E44
		public unsafe Color Accessory9Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250433, XrefRangeEnd = 250437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028BB RID: 10427
		public unsafe Il2CppSystem.Object this[string propertyName]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 250443, RefRangeEnd = 250446, XrefRangeStart = 250437, XrefRangeEnd = 250443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060085EE RID: 34286 RVA: 0x00237CD0 File Offset: 0x00235ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250446, XrefRangeEnd = 250447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060085EF RID: 34287 RVA: 0x00237D20 File Offset: 0x00235F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250447, XrefRangeEnd = 250467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x0003F8F1 File Offset: 0x0003DAF1
		public AvatarSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x060085F1 RID: 34289 RVA: 0x00237D5C File Offset: 0x00235F5C
		// (set) Token: 0x060085F2 RID: 34290 RVA: 0x0003F8FA File Offset: 0x0003DAFA
		public unsafe Color SkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_SkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_SkinColor)) = value;
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x060085F3 RID: 34291 RVA: 0x00237D84 File Offset: 0x00235F84
		// (set) Token: 0x060085F4 RID: 34292 RVA: 0x0003F915 File Offset: 0x0003DB15
		public unsafe float Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x060085F5 RID: 34293 RVA: 0x00237DAC File Offset: 0x00235FAC
		// (set) Token: 0x060085F6 RID: 34294 RVA: 0x0003F930 File Offset: 0x0003DB30
		public unsafe float Gender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Gender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Gender)) = value;
			}
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x060085F7 RID: 34295 RVA: 0x00237DD4 File Offset: 0x00235FD4
		// (set) Token: 0x060085F8 RID: 34296 RVA: 0x0003F94B File Offset: 0x0003DB4B
		public unsafe float Weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Weight)) = value;
			}
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x060085F9 RID: 34297 RVA: 0x00237DFC File Offset: 0x00235FFC
		// (set) Token: 0x060085FA RID: 34298 RVA: 0x0003F966 File Offset: 0x0003DB66
		public unsafe string HairPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x060085FB RID: 34299 RVA: 0x00237E24 File Offset: 0x00236024
		// (set) Token: 0x060085FC RID: 34300 RVA: 0x0003F985 File Offset: 0x0003DB85
		public unsafe Color HairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairColor)) = value;
			}
		}

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x060085FD RID: 34301 RVA: 0x00237E4C File Offset: 0x0023604C
		// (set) Token: 0x060085FE RID: 34302 RVA: 0x0003F9A0 File Offset: 0x0003DBA0
		public unsafe float EyebrowScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowScale)) = value;
			}
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x060085FF RID: 34303 RVA: 0x00237E74 File Offset: 0x00236074
		// (set) Token: 0x06008600 RID: 34304 RVA: 0x0003F9BB File Offset: 0x0003DBBB
		public unsafe float EyebrowThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowThickness)) = value;
			}
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x06008601 RID: 34305 RVA: 0x00237E9C File Offset: 0x0023609C
		// (set) Token: 0x06008602 RID: 34306 RVA: 0x0003F9D6 File Offset: 0x0003DBD6
		public unsafe float EyebrowRestingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight)) = value;
			}
		}

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x06008603 RID: 34307 RVA: 0x00237EC4 File Offset: 0x002360C4
		// (set) Token: 0x06008604 RID: 34308 RVA: 0x0003F9F1 File Offset: 0x0003DBF1
		public unsafe float EyebrowRestingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle)) = value;
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x06008605 RID: 34309 RVA: 0x00237EEC File Offset: 0x002360EC
		// (set) Token: 0x06008606 RID: 34310 RVA: 0x0003FA0C File Offset: 0x0003DC0C
		public unsafe Color LeftEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor)) = value;
			}
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x06008607 RID: 34311 RVA: 0x00237F14 File Offset: 0x00236114
		// (set) Token: 0x06008608 RID: 34312 RVA: 0x0003FA27 File Offset: 0x0003DC27
		public unsafe Color RightEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor)) = value;
			}
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x06008609 RID: 34313 RVA: 0x00237F3C File Offset: 0x0023613C
		// (set) Token: 0x0600860A RID: 34314 RVA: 0x0003FA42 File Offset: 0x0003DC42
		public unsafe Eye.EyeLidConfiguration LeftEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState)) = value;
			}
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x0600860B RID: 34315 RVA: 0x00237F64 File Offset: 0x00236164
		// (set) Token: 0x0600860C RID: 34316 RVA: 0x0003FA5D File Offset: 0x0003DC5D
		public unsafe Eye.EyeLidConfiguration RightEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState)) = value;
			}
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x0600860D RID: 34317 RVA: 0x00237F8C File Offset: 0x0023618C
		// (set) Token: 0x0600860E RID: 34318 RVA: 0x0003FA78 File Offset: 0x0003DC78
		public unsafe string EyeballMaterialIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x0600860F RID: 34319 RVA: 0x00237FB4 File Offset: 0x002361B4
		// (set) Token: 0x06008610 RID: 34320 RVA: 0x0003FA97 File Offset: 0x0003DC97
		public unsafe Color EyeBallTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeBallTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeBallTint)) = value;
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x06008611 RID: 34321 RVA: 0x00237FDC File Offset: 0x002361DC
		// (set) Token: 0x06008612 RID: 34322 RVA: 0x0003FAB2 File Offset: 0x0003DCB2
		public unsafe float PupilDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x06008613 RID: 34323 RVA: 0x00238004 File Offset: 0x00236204
		// (set) Token: 0x06008614 RID: 34324 RVA: 0x0003FACD File Offset: 0x0003DCCD
		public unsafe List<AvatarSettings.LayerSetting> FaceLayerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x06008615 RID: 34325 RVA: 0x00238034 File Offset: 0x00236234
		// (set) Token: 0x06008616 RID: 34326 RVA: 0x0003FAEC File Offset: 0x0003DCEC
		public unsafe List<AvatarSettings.LayerSetting> BodyLayerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x06008617 RID: 34327 RVA: 0x00238064 File Offset: 0x00236264
		// (set) Token: 0x06008618 RID: 34328 RVA: 0x0003FB0B File Offset: 0x0003DD0B
		public unsafe List<AvatarSettings.AccessorySetting> AccessorySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_AccessorySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.AccessorySetting>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_AccessorySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x06008619 RID: 34329 RVA: 0x00238094 File Offset: 0x00236294
		// (set) Token: 0x0600861A RID: 34330 RVA: 0x0003FB2A File Offset: 0x0003DD2A
		public unsafe bool UseCombinedLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer)) = value;
			}
		}

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x0600861B RID: 34331 RVA: 0x002380BC File Offset: 0x002362BC
		// (set) Token: 0x0600861C RID: 34332 RVA: 0x0003FB45 File Offset: 0x0003DD45
		public unsafe string CombinedLayerPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_CombinedLayerPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_CombinedLayerPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x0600861D RID: 34333 RVA: 0x002380E4 File Offset: 0x002362E4
		// (set) Token: 0x0600861E RID: 34334 RVA: 0x0003FB64 File Offset: 0x0003DD64
		public unsafe Texture2D ImpostorTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_ImpostorTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_ImpostorTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005B0B RID: 23307
		private static readonly IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x04005B0C RID: 23308
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04005B0D RID: 23309
		private static readonly IntPtr NativeFieldInfoPtr_Gender;

		// Token: 0x04005B0E RID: 23310
		private static readonly IntPtr NativeFieldInfoPtr_Weight;

		// Token: 0x04005B0F RID: 23311
		private static readonly IntPtr NativeFieldInfoPtr_HairPath;

		// Token: 0x04005B10 RID: 23312
		private static readonly IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x04005B11 RID: 23313
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowScale;

		// Token: 0x04005B12 RID: 23314
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowThickness;

		// Token: 0x04005B13 RID: 23315
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingHeight;

		// Token: 0x04005B14 RID: 23316
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingAngle;

		// Token: 0x04005B15 RID: 23317
		private static readonly IntPtr NativeFieldInfoPtr_LeftEyeLidColor;

		// Token: 0x04005B16 RID: 23318
		private static readonly IntPtr NativeFieldInfoPtr_RightEyeLidColor;

		// Token: 0x04005B17 RID: 23319
		private static readonly IntPtr NativeFieldInfoPtr_LeftEyeRestingState;

		// Token: 0x04005B18 RID: 23320
		private static readonly IntPtr NativeFieldInfoPtr_RightEyeRestingState;

		// Token: 0x04005B19 RID: 23321
		private static readonly IntPtr NativeFieldInfoPtr_EyeballMaterialIdentifier;

		// Token: 0x04005B1A RID: 23322
		private static readonly IntPtr NativeFieldInfoPtr_EyeBallTint;

		// Token: 0x04005B1B RID: 23323
		private static readonly IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04005B1C RID: 23324
		private static readonly IntPtr NativeFieldInfoPtr_FaceLayerSettings;

		// Token: 0x04005B1D RID: 23325
		private static readonly IntPtr NativeFieldInfoPtr_BodyLayerSettings;

		// Token: 0x04005B1E RID: 23326
		private static readonly IntPtr NativeFieldInfoPtr_AccessorySettings;

		// Token: 0x04005B1F RID: 23327
		private static readonly IntPtr NativeFieldInfoPtr_UseCombinedLayer;

		// Token: 0x04005B20 RID: 23328
		private static readonly IntPtr NativeFieldInfoPtr_CombinedLayerPath;

		// Token: 0x04005B21 RID: 23329
		private static readonly IntPtr NativeFieldInfoPtr_ImpostorTexture;

		// Token: 0x04005B22 RID: 23330
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0;

		// Token: 0x04005B23 RID: 23331
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0;

		// Token: 0x04005B24 RID: 23332
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0;

		// Token: 0x04005B25 RID: 23333
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0;

		// Token: 0x04005B26 RID: 23334
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0;

		// Token: 0x04005B27 RID: 23335
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0;

		// Token: 0x04005B28 RID: 23336
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0;

		// Token: 0x04005B29 RID: 23337
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0;

		// Token: 0x04005B2A RID: 23338
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0;

		// Token: 0x04005B2B RID: 23339
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0;

		// Token: 0x04005B2C RID: 23340
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0;

		// Token: 0x04005B2D RID: 23341
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0;

		// Token: 0x04005B2E RID: 23342
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0;

		// Token: 0x04005B2F RID: 23343
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0;

		// Token: 0x04005B30 RID: 23344
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0;

		// Token: 0x04005B31 RID: 23345
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0;

		// Token: 0x04005B32 RID: 23346
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0;

		// Token: 0x04005B33 RID: 23347
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0;

		// Token: 0x04005B34 RID: 23348
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0;

		// Token: 0x04005B35 RID: 23349
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0;

		// Token: 0x04005B36 RID: 23350
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0;

		// Token: 0x04005B37 RID: 23351
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0;

		// Token: 0x04005B38 RID: 23352
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0;

		// Token: 0x04005B39 RID: 23353
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0;

		// Token: 0x04005B3A RID: 23354
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0;

		// Token: 0x04005B3B RID: 23355
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0;

		// Token: 0x04005B3C RID: 23356
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0;

		// Token: 0x04005B3D RID: 23357
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0;

		// Token: 0x04005B3E RID: 23358
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0;

		// Token: 0x04005B3F RID: 23359
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0;

		// Token: 0x04005B40 RID: 23360
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0;

		// Token: 0x04005B41 RID: 23361
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0;

		// Token: 0x04005B42 RID: 23362
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0;

		// Token: 0x04005B43 RID: 23363
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0;

		// Token: 0x04005B44 RID: 23364
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0;

		// Token: 0x04005B45 RID: 23365
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0;

		// Token: 0x04005B46 RID: 23366
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0;

		// Token: 0x04005B47 RID: 23367
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0;

		// Token: 0x04005B48 RID: 23368
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0;

		// Token: 0x04005B49 RID: 23369
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0;

		// Token: 0x04005B4A RID: 23370
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0;

		// Token: 0x04005B4B RID: 23371
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0;

		// Token: 0x04005B4C RID: 23372
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0;

		// Token: 0x04005B4D RID: 23373
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0;

		// Token: 0x04005B4E RID: 23374
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_String_0;

		// Token: 0x04005B4F RID: 23375
		private static readonly IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04005B50 RID: 23376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEC RID: 2796
		[Serializable]
		public sealed class LayerSetting : ValueType
		{
			// Token: 0x0600D57D RID: 54653 RVA: 0x0032E1A8 File Offset: 0x0032C3A8
			// Note: this type is marked as 'beforefieldinit'.
			static LayerSetting()
			{
				Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LayerSetting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr);
				AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr, "layerPath");
				AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr, "layerTint");
			}

			// Token: 0x0600D57E RID: 54654 RVA: 0x00067DA4 File Offset: 0x00065FA4
			public LayerSetting(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D57F RID: 54655 RVA: 0x00067DAD File Offset: 0x00065FAD
			public LayerSetting() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr))
			{
			}

			// Token: 0x17004228 RID: 16936
			// (get) Token: 0x0600D580 RID: 54656 RVA: 0x0032E1FC File Offset: 0x0032C3FC
			// (set) Token: 0x0600D581 RID: 54657 RVA: 0x00067DBF File Offset: 0x00065FBF
			public unsafe string layerPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004229 RID: 16937
			// (get) Token: 0x0600D582 RID: 54658 RVA: 0x0032E224 File Offset: 0x0032C424
			// (set) Token: 0x0600D583 RID: 54659 RVA: 0x00067DDE File Offset: 0x00065FDE
			public unsafe Color layerTint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint)) = value;
				}
			}

			// Token: 0x04008F9D RID: 36765
			private static readonly IntPtr NativeFieldInfoPtr_layerPath;

			// Token: 0x04008F9E RID: 36766
			private static readonly IntPtr NativeFieldInfoPtr_layerTint;
		}

		// Token: 0x02000AED RID: 2797
		[Serializable]
		public class AccessorySetting : Il2CppSystem.Object
		{
			// Token: 0x0600D584 RID: 54660 RVA: 0x0032E24C File Offset: 0x0032C44C
			// Note: this type is marked as 'beforefieldinit'.
			static AccessorySetting()
			{
				Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "AccessorySetting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr);
				AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, "path");
				AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, "color");
				AvatarSettings.AccessorySetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, 100680049);
			}

			// Token: 0x0600D585 RID: 54661 RVA: 0x0032E2B4 File Offset: 0x0032C4B4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccessorySetting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.AccessorySetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D586 RID: 54662 RVA: 0x00067DF9 File Offset: 0x00065FF9
			public AccessorySetting(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422A RID: 16938
			// (get) Token: 0x0600D587 RID: 54663 RVA: 0x0032E2F0 File Offset: 0x0032C4F0
			// (set) Token: 0x0600D588 RID: 54664 RVA: 0x00067E02 File Offset: 0x00066002
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700422B RID: 16939
			// (get) Token: 0x0600D589 RID: 54665 RVA: 0x0032E318 File Offset: 0x0032C518
			// (set) Token: 0x0600D58A RID: 54666 RVA: 0x00067E21 File Offset: 0x00066021
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008F9F RID: 36767
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04008FA0 RID: 36768
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008FA1 RID: 36769
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
