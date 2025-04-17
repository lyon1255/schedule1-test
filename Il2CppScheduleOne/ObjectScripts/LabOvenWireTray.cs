using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000749 RID: 1865
	public class LabOvenWireTray : MonoBehaviour
	{
		// Token: 0x0600AEEC RID: 44780 RVA: 0x002BA2E8 File Offset: 0x002B84E8
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenWireTray()
		{
			Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenWireTray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr);
			LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "HIT_OFFSET_MAX");
			LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "HIT_OFFSET_MIN");
			LabOvenWireTray.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "<Interactable>k__BackingField");
			LabOvenWireTray.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "<TargetPosition>k__BackingField");
			LabOvenWireTray.NativeFieldInfoPtr__ActualPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "<ActualPosition>k__BackingField");
			LabOvenWireTray.NativeFieldInfoPtr_Tray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "Tray");
			LabOvenWireTray.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "PlaneNormal");
			LabOvenWireTray.NativeFieldInfoPtr_ClosedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "ClosedPosition");
			LabOvenWireTray.NativeFieldInfoPtr_OpenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "OpenPosition");
			LabOvenWireTray.NativeFieldInfoPtr_OvenDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "OvenDoor");
			LabOvenWireTray.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "MoveSpeed");
			LabOvenWireTray.NativeFieldInfoPtr_DoorClampCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "DoorClampCurve");
			LabOvenWireTray.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "clickOffset");
			LabOvenWireTray.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "isMoving");
			LabOvenWireTray.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684798);
			LabOvenWireTray.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684799);
			LabOvenWireTray.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684800);
			LabOvenWireTray.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684801);
			LabOvenWireTray.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684802);
			LabOvenWireTray.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684803);
			LabOvenWireTray.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684804);
			LabOvenWireTray.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684805);
			LabOvenWireTray.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684806);
			LabOvenWireTray.NativeMethodInfoPtr_ClampAngle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684807);
			LabOvenWireTray.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684808);
			LabOvenWireTray.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684809);
			LabOvenWireTray.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684810);
			LabOvenWireTray.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684811);
			LabOvenWireTray.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684812);
			LabOvenWireTray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684813);
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600AEED RID: 44781 RVA: 0x002BA570 File Offset: 0x002B8770
		// (set) Token: 0x0600AEEE RID: 44782 RVA: 0x002BA5AC File Offset: 0x002B87AC
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600AEEF RID: 44783 RVA: 0x002BA5EC File Offset: 0x002B87EC
		// (set) Token: 0x0600AEF0 RID: 44784 RVA: 0x002BA628 File Offset: 0x002B8828
		public unsafe float TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29987, XrefRangeStart = 29976, XrefRangeEnd = 29987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600AEF1 RID: 44785 RVA: 0x002BA668 File Offset: 0x002B8868
		// (set) Token: 0x0600AEF2 RID: 44786 RVA: 0x002BA6A4 File Offset: 0x002B88A4
		public unsafe float ActualPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x002BA6E4 File Offset: 0x002B88E4
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x002BA718 File Offset: 0x002B8918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302167, XrefRangeEnd = 302186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x002BA74C File Offset: 0x002B894C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302195, RefRangeEnd = 302196, XrefRangeStart = 302186, XrefRangeEnd = 302195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEF6 RID: 44790 RVA: 0x002BA780 File Offset: 0x002B8980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302196, XrefRangeEnd = 302202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_ClampAngle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEF7 RID: 44791 RVA: 0x002BA7B4 File Offset: 0x002B89B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEF8 RID: 44792 RVA: 0x002BA7F4 File Offset: 0x002B89F4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29987, XrefRangeStart = 29976, XrefRangeEnd = 29987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEF9 RID: 44793 RVA: 0x002BA834 File Offset: 0x002B8A34
		[CallerCount(0)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEFA RID: 44794 RVA: 0x002BA874 File Offset: 0x002B8A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302215, RefRangeEnd = 302216, XrefRangeStart = 302202, XrefRangeEnd = 302215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AEFB RID: 44795 RVA: 0x002BA8B0 File Offset: 0x002B8AB0
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEFC RID: 44796 RVA: 0x002BA8E4 File Offset: 0x002B8AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302216, XrefRangeEnd = 302219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenWireTray() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEFD RID: 44797 RVA: 0x00055FA6 File Offset: 0x000541A6
		public LabOvenWireTray(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0600AEFE RID: 44798 RVA: 0x002BA920 File Offset: 0x002B8B20
		// (set) Token: 0x0600AEFF RID: 44799 RVA: 0x00055FAF File Offset: 0x000541AF
		public unsafe static float HIT_OFFSET_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&value));
			}
		}

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0600AF00 RID: 44800 RVA: 0x002BA93C File Offset: 0x002B8B3C
		// (set) Token: 0x0600AF01 RID: 44801 RVA: 0x00055FBD File Offset: 0x000541BD
		public unsafe static float HIT_OFFSET_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&value));
			}
		}

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0600AF02 RID: 44802 RVA: 0x002BA958 File Offset: 0x002B8B58
		// (set) Token: 0x0600AF03 RID: 44803 RVA: 0x00055FCB File Offset: 0x000541CB
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0600AF04 RID: 44804 RVA: 0x002BA980 File Offset: 0x002B8B80
		// (set) Token: 0x0600AF05 RID: 44805 RVA: 0x00055FE6 File Offset: 0x000541E6
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0600AF06 RID: 44806 RVA: 0x002BA9A8 File Offset: 0x002B8BA8
		// (set) Token: 0x0600AF07 RID: 44807 RVA: 0x00056001 File Offset: 0x00054201
		public unsafe float _ActualPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__ActualPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__ActualPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0600AF08 RID: 44808 RVA: 0x002BA9D0 File Offset: 0x002B8BD0
		// (set) Token: 0x0600AF09 RID: 44809 RVA: 0x0005601C File Offset: 0x0005421C
		public unsafe Transform Tray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_Tray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_Tray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0600AF0A RID: 44810 RVA: 0x002BAA00 File Offset: 0x002B8C00
		// (set) Token: 0x0600AF0B RID: 44811 RVA: 0x0005603B File Offset: 0x0005423B
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0600AF0C RID: 44812 RVA: 0x002BAA30 File Offset: 0x002B8C30
		// (set) Token: 0x0600AF0D RID: 44813 RVA: 0x0005605A File Offset: 0x0005425A
		public unsafe Transform ClosedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_ClosedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_ClosedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0600AF0E RID: 44814 RVA: 0x002BAA60 File Offset: 0x002B8C60
		// (set) Token: 0x0600AF0F RID: 44815 RVA: 0x00056079 File Offset: 0x00054279
		public unsafe Transform OpenPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OpenPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OpenPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0600AF10 RID: 44816 RVA: 0x002BAA90 File Offset: 0x002B8C90
		// (set) Token: 0x0600AF11 RID: 44817 RVA: 0x00056098 File Offset: 0x00054298
		public unsafe LabOvenDoor OvenDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OvenDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OvenDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0600AF12 RID: 44818 RVA: 0x002BAAC0 File Offset: 0x002B8CC0
		// (set) Token: 0x0600AF13 RID: 44819 RVA: 0x000560B7 File Offset: 0x000542B7
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0600AF14 RID: 44820 RVA: 0x002BAAE8 File Offset: 0x002B8CE8
		// (set) Token: 0x0600AF15 RID: 44821 RVA: 0x000560D2 File Offset: 0x000542D2
		public unsafe AnimationCurve DoorClampCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_DoorClampCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_DoorClampCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600AF16 RID: 44822 RVA: 0x002BAB18 File Offset: 0x002B8D18
		// (set) Token: 0x0600AF17 RID: 44823 RVA: 0x000560F1 File Offset: 0x000542F1
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600AF18 RID: 44824 RVA: 0x002BAB40 File Offset: 0x002B8D40
		// (set) Token: 0x0600AF19 RID: 44825 RVA: 0x0005610C File Offset: 0x0005430C
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x040075BC RID: 30140
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MAX;

		// Token: 0x040075BD RID: 30141
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MIN;

		// Token: 0x040075BE RID: 30142
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040075BF RID: 30143
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x040075C0 RID: 30144
		private static readonly IntPtr NativeFieldInfoPtr__ActualPosition_k__BackingField;

		// Token: 0x040075C1 RID: 30145
		private static readonly IntPtr NativeFieldInfoPtr_Tray;

		// Token: 0x040075C2 RID: 30146
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x040075C3 RID: 30147
		private static readonly IntPtr NativeFieldInfoPtr_ClosedPosition;

		// Token: 0x040075C4 RID: 30148
		private static readonly IntPtr NativeFieldInfoPtr_OpenPosition;

		// Token: 0x040075C5 RID: 30149
		private static readonly IntPtr NativeFieldInfoPtr_OvenDoor;

		// Token: 0x040075C6 RID: 30150
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x040075C7 RID: 30151
		private static readonly IntPtr NativeFieldInfoPtr_DoorClampCurve;

		// Token: 0x040075C8 RID: 30152
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x040075C9 RID: 30153
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x040075CA RID: 30154
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040075CB RID: 30155
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040075CC RID: 30156
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x040075CD RID: 30157
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x040075CE RID: 30158
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0;

		// Token: 0x040075CF RID: 30159
		private static readonly IntPtr NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0;

		// Token: 0x040075D0 RID: 30160
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040075D1 RID: 30161
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040075D2 RID: 30162
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x040075D3 RID: 30163
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Void_0;

		// Token: 0x040075D4 RID: 30164
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040075D5 RID: 30165
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x040075D6 RID: 30166
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x040075D7 RID: 30167
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x040075D8 RID: 30168
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x040075D9 RID: 30169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
