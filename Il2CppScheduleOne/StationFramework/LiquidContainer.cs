using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppLiquidVolumeFX;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058B RID: 1419
	public class LiquidContainer : MonoBehaviour
	{
		// Token: 0x06007CE3 RID: 31971 RVA: 0x00218264 File Offset: 0x00216464
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidContainer()
		{
			Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr);
			LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "<CurrentLiquidLevel>k__BackingField");
			LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "<LiquidColor>k__BackingField");
			LiquidContainer.NativeFieldInfoPtr_Viscosity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "Viscosity");
			LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "AdjustMurkiness");
			LiquidContainer.NativeFieldInfoPtr_LiquidVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "LiquidVolume");
			LiquidContainer.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "Collider");
			LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "ColliderTransform_Min");
			LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "ColliderTransform_Max");
			LiquidContainer.NativeFieldInfoPtr_MaxLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "MaxLevel");
			LiquidContainer.NativeFieldInfoPtr_liquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "liquidMesh");
			LiquidContainer.NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678943);
			LiquidContainer.NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678944);
			LiquidContainer.NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678945);
			LiquidContainer.NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678946);
			LiquidContainer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678947);
			LiquidContainer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678948);
			LiquidContainer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678949);
			LiquidContainer.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678950);
			LiquidContainer.NativeMethodInfoPtr_UpdateLighting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678951);
			LiquidContainer.NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678952);
			LiquidContainer.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678953);
			LiquidContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678954);
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x06007CE4 RID: 31972 RVA: 0x0021844C File Offset: 0x0021664C
		// (set) Token: 0x06007CE5 RID: 31973 RVA: 0x00218488 File Offset: 0x00216688
		public unsafe float CurrentLiquidLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29961, RefRangeEnd = 29962, XrefRangeStart = 29961, XrefRangeEnd = 29962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x06007CE6 RID: 31974 RVA: 0x002184C8 File Offset: 0x002166C8
		// (set) Token: 0x06007CE7 RID: 31975 RVA: 0x00218504 File Offset: 0x00216704
		public unsafe Color LiquidColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007CE8 RID: 31976 RVA: 0x00218544 File Offset: 0x00216744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237468, XrefRangeEnd = 237475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x00218578 File Offset: 0x00216778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237475, XrefRangeEnd = 237498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x002185AC File Offset: 0x002167AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237498, XrefRangeEnd = 237516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CEB RID: 31979 RVA: 0x002185E0 File Offset: 0x002167E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237516, XrefRangeEnd = 237517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CEC RID: 31980 RVA: 0x00218614 File Offset: 0x00216814
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237523, RefRangeEnd = 237527, XrefRangeStart = 237517, XrefRangeEnd = 237523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLighting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_UpdateLighting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CED RID: 31981 RVA: 0x00218648 File Offset: 0x00216848
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 237562, RefRangeEnd = 237570, XrefRangeStart = 237527, XrefRangeEnd = 237562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLiquidLevel(float level, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CEE RID: 31982 RVA: 0x00218694 File Offset: 0x00216894
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237573, RefRangeEnd = 237576, XrefRangeStart = 237570, XrefRangeEnd = 237573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLiquidColor(Color color, bool setColorVariable = true, bool updateLigting = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setColorVariable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLigting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x002186F0 File Offset: 0x002168F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237576, XrefRangeEnd = 237577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CF0 RID: 31984 RVA: 0x0003B4AC File Offset: 0x000396AC
		public LiquidContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x06007CF1 RID: 31985 RVA: 0x0021872C File Offset: 0x0021692C
		// (set) Token: 0x06007CF2 RID: 31986 RVA: 0x0003B4B5 File Offset: 0x000396B5
		public unsafe float _CurrentLiquidLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x06007CF3 RID: 31987 RVA: 0x00218754 File Offset: 0x00216954
		// (set) Token: 0x06007CF4 RID: 31988 RVA: 0x0003B4D0 File Offset: 0x000396D0
		public unsafe Color _LiquidColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField)) = value;
			}
		}

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x06007CF5 RID: 31989 RVA: 0x0021877C File Offset: 0x0021697C
		// (set) Token: 0x06007CF6 RID: 31990 RVA: 0x0003B4EB File Offset: 0x000396EB
		public unsafe float Viscosity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Viscosity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Viscosity)) = value;
			}
		}

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x06007CF7 RID: 31991 RVA: 0x002187A4 File Offset: 0x002169A4
		// (set) Token: 0x06007CF8 RID: 31992 RVA: 0x0003B506 File Offset: 0x00039706
		public unsafe bool AdjustMurkiness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness)) = value;
			}
		}

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x06007CF9 RID: 31993 RVA: 0x002187CC File Offset: 0x002169CC
		// (set) Token: 0x06007CFA RID: 31994 RVA: 0x0003B521 File Offset: 0x00039721
		public unsafe LiquidVolume LiquidVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_LiquidVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_LiquidVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x06007CFB RID: 31995 RVA: 0x002187FC File Offset: 0x002169FC
		// (set) Token: 0x06007CFC RID: 31996 RVA: 0x0003B540 File Offset: 0x00039740
		public unsafe LiquidVolumeCollider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x06007CFD RID: 31997 RVA: 0x0021882C File Offset: 0x00216A2C
		// (set) Token: 0x06007CFE RID: 31998 RVA: 0x0003B55F File Offset: 0x0003975F
		public unsafe Transform ColliderTransform_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x06007CFF RID: 31999 RVA: 0x0021885C File Offset: 0x00216A5C
		// (set) Token: 0x06007D00 RID: 32000 RVA: 0x0003B57E File Offset: 0x0003977E
		public unsafe Transform ColliderTransform_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x06007D01 RID: 32001 RVA: 0x0021888C File Offset: 0x00216A8C
		// (set) Token: 0x06007D02 RID: 32002 RVA: 0x0003B59D File Offset: 0x0003979D
		public unsafe float MaxLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_MaxLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_MaxLevel)) = value;
			}
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x06007D03 RID: 32003 RVA: 0x002188B4 File Offset: 0x00216AB4
		// (set) Token: 0x06007D04 RID: 32004 RVA: 0x0003B5B8 File Offset: 0x000397B8
		public unsafe MeshRenderer liquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_liquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_liquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005500 RID: 21760
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField;

		// Token: 0x04005501 RID: 21761
		private static readonly IntPtr NativeFieldInfoPtr__LiquidColor_k__BackingField;

		// Token: 0x04005502 RID: 21762
		private static readonly IntPtr NativeFieldInfoPtr_Viscosity;

		// Token: 0x04005503 RID: 21763
		private static readonly IntPtr NativeFieldInfoPtr_AdjustMurkiness;

		// Token: 0x04005504 RID: 21764
		private static readonly IntPtr NativeFieldInfoPtr_LiquidVolume;

		// Token: 0x04005505 RID: 21765
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005506 RID: 21766
		private static readonly IntPtr NativeFieldInfoPtr_ColliderTransform_Min;

		// Token: 0x04005507 RID: 21767
		private static readonly IntPtr NativeFieldInfoPtr_ColliderTransform_Max;

		// Token: 0x04005508 RID: 21768
		private static readonly IntPtr NativeFieldInfoPtr_MaxLevel;

		// Token: 0x04005509 RID: 21769
		private static readonly IntPtr NativeFieldInfoPtr_liquidMesh;

		// Token: 0x0400550A RID: 21770
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0;

		// Token: 0x0400550B RID: 21771
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0;

		// Token: 0x0400550C RID: 21772
		private static readonly IntPtr NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0;

		// Token: 0x0400550D RID: 21773
		private static readonly IntPtr NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0;

		// Token: 0x0400550E RID: 21774
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400550F RID: 21775
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005510 RID: 21776
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005511 RID: 21777
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04005512 RID: 21778
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLighting_Private_Void_0;

		// Token: 0x04005513 RID: 21779
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0;

		// Token: 0x04005514 RID: 21780
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0;

		// Token: 0x04005515 RID: 21781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
