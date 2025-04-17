using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000747 RID: 1863
	public class LabOvenDoor : MonoBehaviour
	{
		// Token: 0x0600AE9D RID: 44701 RVA: 0x002B95D8 File Offset: 0x002B77D8
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenDoor()
		{
			Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr);
			LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HIT_OFFSET_MAX");
			LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HIT_OFFSET_MIN");
			LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DOOR_ANGLE_CLOSED");
			LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DOOR_ANGLE_OPEN");
			LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<Interactable>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<TargetPosition>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<ActualPosition>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HandleClickable");
			LabOvenDoor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "Door");
			LabOvenDoor.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "PlaneNormal");
			LabOvenDoor.NativeFieldInfoPtr_HitMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HitMapCurve");
			LabOvenDoor.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "OpenSound");
			LabOvenDoor.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "CloseSound");
			LabOvenDoor.NativeFieldInfoPtr_ShutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "ShutSound");
			LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DoorMoveSpeed");
			LabOvenDoor.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "clickOffset");
			LabOvenDoor.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "isMoving");
			LabOvenDoor.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684779);
			LabOvenDoor.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684780);
			LabOvenDoor.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684781);
			LabOvenDoor.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684782);
			LabOvenDoor.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684783);
			LabOvenDoor.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684784);
			LabOvenDoor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684785);
			LabOvenDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684786);
			LabOvenDoor.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684787);
			LabOvenDoor.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684788);
			LabOvenDoor.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684789);
			LabOvenDoor.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684790);
			LabOvenDoor.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684791);
			LabOvenDoor.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684792);
			LabOvenDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684793);
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600AE9E RID: 44702 RVA: 0x002B9888 File Offset: 0x002B7A88
		// (set) Token: 0x0600AE9F RID: 44703 RVA: 0x002B98C4 File Offset: 0x002B7AC4
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600AEA0 RID: 44704 RVA: 0x002B9904 File Offset: 0x002B7B04
		// (set) Token: 0x0600AEA1 RID: 44705 RVA: 0x002B9940 File Offset: 0x002B7B40
		public unsafe float TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600AEA2 RID: 44706 RVA: 0x002B9980 File Offset: 0x002B7B80
		// (set) Token: 0x0600AEA3 RID: 44707 RVA: 0x002B99BC File Offset: 0x002B7BBC
		public unsafe float ActualPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x002B99FC File Offset: 0x002B7BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302074, XrefRangeEnd = 302092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA5 RID: 44709 RVA: 0x002B9A30 File Offset: 0x002B7C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302092, XrefRangeEnd = 302106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x002B9A64 File Offset: 0x002B7C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302106, XrefRangeEnd = 302114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x002B9A98 File Offset: 0x002B7C98
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 298642, RefRangeEnd = 298657, XrefRangeStart = 298642, XrefRangeEnd = 298657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x002B9AD8 File Offset: 0x002B7CD8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 302116, RefRangeEnd = 302134, XrefRangeStart = 302114, XrefRangeEnd = 302116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float newPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA9 RID: 44713 RVA: 0x002B9B18 File Offset: 0x002B7D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302134, XrefRangeEnd = 302137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEAA RID: 44714 RVA: 0x002B9B58 File Offset: 0x002B7D58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302150, RefRangeEnd = 302152, XrefRangeStart = 302137, XrefRangeEnd = 302150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AEAB RID: 44715 RVA: 0x002B9B94 File Offset: 0x002B7D94
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEAC RID: 44716 RVA: 0x002B9BC8 File Offset: 0x002B7DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302152, XrefRangeEnd = 302155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEAD RID: 44717 RVA: 0x00055C9C File Offset: 0x00053E9C
		public LabOvenDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600AEAE RID: 44718 RVA: 0x002B9C04 File Offset: 0x002B7E04
		// (set) Token: 0x0600AEAF RID: 44719 RVA: 0x00055CA5 File Offset: 0x00053EA5
		public unsafe static float HIT_OFFSET_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&value));
			}
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600AEB0 RID: 44720 RVA: 0x002B9C20 File Offset: 0x002B7E20
		// (set) Token: 0x0600AEB1 RID: 44721 RVA: 0x00055CB3 File Offset: 0x00053EB3
		public unsafe static float HIT_OFFSET_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&value));
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600AEB2 RID: 44722 RVA: 0x002B9C3C File Offset: 0x002B7E3C
		// (set) Token: 0x0600AEB3 RID: 44723 RVA: 0x00055CC1 File Offset: 0x00053EC1
		public unsafe static float DOOR_ANGLE_CLOSED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED, (void*)(&value));
			}
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600AEB4 RID: 44724 RVA: 0x002B9C58 File Offset: 0x002B7E58
		// (set) Token: 0x0600AEB5 RID: 44725 RVA: 0x00055CCF File Offset: 0x00053ECF
		public unsafe static float DOOR_ANGLE_OPEN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN, (void*)(&value));
			}
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600AEB6 RID: 44726 RVA: 0x002B9C74 File Offset: 0x002B7E74
		// (set) Token: 0x0600AEB7 RID: 44727 RVA: 0x00055CDD File Offset: 0x00053EDD
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600AEB8 RID: 44728 RVA: 0x002B9C9C File Offset: 0x002B7E9C
		// (set) Token: 0x0600AEB9 RID: 44729 RVA: 0x00055CF8 File Offset: 0x00053EF8
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x002B9CC4 File Offset: 0x002B7EC4
		// (set) Token: 0x0600AEBB RID: 44731 RVA: 0x00055D13 File Offset: 0x00053F13
		public unsafe float _ActualPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600AEBC RID: 44732 RVA: 0x002B9CEC File Offset: 0x002B7EEC
		// (set) Token: 0x0600AEBD RID: 44733 RVA: 0x00055D2E File Offset: 0x00053F2E
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600AEBE RID: 44734 RVA: 0x002B9D1C File Offset: 0x002B7F1C
		// (set) Token: 0x0600AEBF RID: 44735 RVA: 0x00055D4D File Offset: 0x00053F4D
		public unsafe Transform Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600AEC0 RID: 44736 RVA: 0x002B9D4C File Offset: 0x002B7F4C
		// (set) Token: 0x0600AEC1 RID: 44737 RVA: 0x00055D6C File Offset: 0x00053F6C
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600AEC2 RID: 44738 RVA: 0x002B9D7C File Offset: 0x002B7F7C
		// (set) Token: 0x0600AEC3 RID: 44739 RVA: 0x00055D8B File Offset: 0x00053F8B
		public unsafe AnimationCurve HitMapCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HitMapCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HitMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600AEC4 RID: 44740 RVA: 0x002B9DAC File Offset: 0x002B7FAC
		// (set) Token: 0x0600AEC5 RID: 44741 RVA: 0x00055DAA File Offset: 0x00053FAA
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600AEC6 RID: 44742 RVA: 0x002B9DDC File Offset: 0x002B7FDC
		// (set) Token: 0x0600AEC7 RID: 44743 RVA: 0x00055DC9 File Offset: 0x00053FC9
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600AEC8 RID: 44744 RVA: 0x002B9E0C File Offset: 0x002B800C
		// (set) Token: 0x0600AEC9 RID: 44745 RVA: 0x00055DE8 File Offset: 0x00053FE8
		public unsafe AudioSourceController ShutSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_ShutSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_ShutSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600AECA RID: 44746 RVA: 0x002B9E3C File Offset: 0x002B803C
		// (set) Token: 0x0600AECB RID: 44747 RVA: 0x00055E07 File Offset: 0x00054007
		public unsafe float DoorMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed)) = value;
			}
		}

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600AECC RID: 44748 RVA: 0x002B9E64 File Offset: 0x002B8064
		// (set) Token: 0x0600AECD RID: 44749 RVA: 0x00055E22 File Offset: 0x00054022
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600AECE RID: 44750 RVA: 0x002B9E8C File Offset: 0x002B808C
		// (set) Token: 0x0600AECF RID: 44751 RVA: 0x00055E3D File Offset: 0x0005403D
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x0400758D RID: 30093
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MAX;

		// Token: 0x0400758E RID: 30094
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MIN;

		// Token: 0x0400758F RID: 30095
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_ANGLE_CLOSED;

		// Token: 0x04007590 RID: 30096
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_ANGLE_OPEN;

		// Token: 0x04007591 RID: 30097
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x04007592 RID: 30098
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x04007593 RID: 30099
		private static readonly IntPtr NativeFieldInfoPtr__ActualPosition_k__BackingField;

		// Token: 0x04007594 RID: 30100
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04007595 RID: 30101
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04007596 RID: 30102
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04007597 RID: 30103
		private static readonly IntPtr NativeFieldInfoPtr_HitMapCurve;

		// Token: 0x04007598 RID: 30104
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04007599 RID: 30105
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x0400759A RID: 30106
		private static readonly IntPtr NativeFieldInfoPtr_ShutSound;

		// Token: 0x0400759B RID: 30107
		private static readonly IntPtr NativeFieldInfoPtr_DoorMoveSpeed;

		// Token: 0x0400759C RID: 30108
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x0400759D RID: 30109
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x0400759E RID: 30110
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x0400759F RID: 30111
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040075A0 RID: 30112
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x040075A1 RID: 30113
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x040075A2 RID: 30114
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0;

		// Token: 0x040075A3 RID: 30115
		private static readonly IntPtr NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0;

		// Token: 0x040075A4 RID: 30116
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040075A5 RID: 30117
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040075A6 RID: 30118
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x040075A7 RID: 30119
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040075A8 RID: 30120
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x040075A9 RID: 30121
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x040075AA RID: 30122
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x040075AB RID: 30123
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x040075AC RID: 30124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
