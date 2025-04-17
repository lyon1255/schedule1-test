using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073A RID: 1850
	public class BrickPressHandle : MonoBehaviour
	{
		// Token: 0x0600A9D1 RID: 43473 RVA: 0x002A6A88 File Offset: 0x002A4C88
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressHandle()
		{
			Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BrickPressHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr);
			BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<Interactable>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<CurrentPosition>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<TargetPosition>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr_lastClickPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "lastClickPosition");
			BrickPressHandle.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "MoveSpeed");
			BrickPressHandle.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "Locked");
			BrickPressHandle.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "PlaneNormal");
			BrickPressHandle.NativeFieldInfoPtr_RaisedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "RaisedTransform");
			BrickPressHandle.NativeFieldInfoPtr_LoweredTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "LoweredTransform");
			BrickPressHandle.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "HandleClickable");
			BrickPressHandle.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "ClickSound");
			BrickPressHandle.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "clickOffset");
			BrickPressHandle.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "isMoving");
			BrickPressHandle.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684132);
			BrickPressHandle.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684133);
			BrickPressHandle.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684134);
			BrickPressHandle.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684135);
			BrickPressHandle.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684136);
			BrickPressHandle.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684137);
			BrickPressHandle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684138);
			BrickPressHandle.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684139);
			BrickPressHandle.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684140);
			BrickPressHandle.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684141);
			BrickPressHandle.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684142);
			BrickPressHandle.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684143);
			BrickPressHandle.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684144);
			BrickPressHandle.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684145);
			BrickPressHandle.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684146);
			BrickPressHandle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684147);
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600A9D2 RID: 43474 RVA: 0x002A6CFC File Offset: 0x002A4EFC
		// (set) Token: 0x0600A9D3 RID: 43475 RVA: 0x002A6D38 File Offset: 0x002A4F38
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600A9D4 RID: 43476 RVA: 0x002A6D78 File Offset: 0x002A4F78
		// (set) Token: 0x0600A9D5 RID: 43477 RVA: 0x002A6DB4 File Offset: 0x002A4FB4
		public unsafe float CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600A9D6 RID: 43478 RVA: 0x002A6DF4 File Offset: 0x002A4FF4
		// (set) Token: 0x0600A9D7 RID: 43479 RVA: 0x002A6E30 File Offset: 0x002A5030
		public unsafe float TargetPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x002A6E70 File Offset: 0x002A5070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295087, XrefRangeEnd = 295104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x002A6EA4 File Offset: 0x002A50A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295104, XrefRangeEnd = 295116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x002A6ED8 File Offset: 0x002A50D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295124, RefRangeEnd = 295125, XrefRangeStart = 295116, XrefRangeEnd = 295124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x002A6F0C File Offset: 0x002A510C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 81304, RefRangeEnd = 81314, XrefRangeStart = 81304, XrefRangeEnd = 81314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSound(float difference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x002A6F4C File Offset: 0x002A514C
		[CallerCount(0)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x002A6F8C File Offset: 0x002A518C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295125, RefRangeEnd = 295128, XrefRangeStart = 295125, XrefRangeEnd = 295125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x002A6FCC File Offset: 0x002A51CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295128, XrefRangeEnd = 295131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x002A700C File Offset: 0x002A520C
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x002A7040 File Offset: 0x002A5240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295144, RefRangeEnd = 295146, XrefRangeStart = 295131, XrefRangeEnd = 295144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x002A707C File Offset: 0x002A527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295146, XrefRangeEnd = 295149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressHandle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x000538F0 File Offset: 0x00051AF0
		public BrickPressHandle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0600A9E3 RID: 43491 RVA: 0x002A70B8 File Offset: 0x002A52B8
		// (set) Token: 0x0600A9E4 RID: 43492 RVA: 0x000538F9 File Offset: 0x00051AF9
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600A9E5 RID: 43493 RVA: 0x002A70E0 File Offset: 0x002A52E0
		// (set) Token: 0x0600A9E6 RID: 43494 RVA: 0x00053914 File Offset: 0x00051B14
		public unsafe float _CurrentPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600A9E7 RID: 43495 RVA: 0x002A7108 File Offset: 0x002A5308
		// (set) Token: 0x0600A9E8 RID: 43496 RVA: 0x0005392F File Offset: 0x00051B2F
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600A9E9 RID: 43497 RVA: 0x002A7130 File Offset: 0x002A5330
		// (set) Token: 0x0600A9EA RID: 43498 RVA: 0x0005394A File Offset: 0x00051B4A
		public unsafe float lastClickPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_lastClickPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_lastClickPosition)) = value;
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600A9EB RID: 43499 RVA: 0x002A7158 File Offset: 0x002A5358
		// (set) Token: 0x0600A9EC RID: 43500 RVA: 0x00053965 File Offset: 0x00051B65
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600A9ED RID: 43501 RVA: 0x002A7180 File Offset: 0x002A5380
		// (set) Token: 0x0600A9EE RID: 43502 RVA: 0x00053980 File Offset: 0x00051B80
		public unsafe bool Locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_Locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_Locked)) = value;
			}
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600A9EF RID: 43503 RVA: 0x002A71A8 File Offset: 0x002A53A8
		// (set) Token: 0x0600A9F0 RID: 43504 RVA: 0x0005399B File Offset: 0x00051B9B
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600A9F1 RID: 43505 RVA: 0x002A71D8 File Offset: 0x002A53D8
		// (set) Token: 0x0600A9F2 RID: 43506 RVA: 0x000539BA File Offset: 0x00051BBA
		public unsafe Transform RaisedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_RaisedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_RaisedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600A9F3 RID: 43507 RVA: 0x002A7208 File Offset: 0x002A5408
		// (set) Token: 0x0600A9F4 RID: 43508 RVA: 0x000539D9 File Offset: 0x00051BD9
		public unsafe Transform LoweredTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_LoweredTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_LoweredTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600A9F5 RID: 43509 RVA: 0x002A7238 File Offset: 0x002A5438
		// (set) Token: 0x0600A9F6 RID: 43510 RVA: 0x000539F8 File Offset: 0x00051BF8
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0600A9F7 RID: 43511 RVA: 0x002A7268 File Offset: 0x002A5468
		// (set) Token: 0x0600A9F8 RID: 43512 RVA: 0x00053A17 File Offset: 0x00051C17
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600A9F9 RID: 43513 RVA: 0x002A7298 File Offset: 0x002A5498
		// (set) Token: 0x0600A9FA RID: 43514 RVA: 0x00053A36 File Offset: 0x00051C36
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600A9FB RID: 43515 RVA: 0x002A72C0 File Offset: 0x002A54C0
		// (set) Token: 0x0600A9FC RID: 43516 RVA: 0x00053A51 File Offset: 0x00051C51
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x0400720B RID: 29195
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x0400720C RID: 29196
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPosition_k__BackingField;

		// Token: 0x0400720D RID: 29197
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x0400720E RID: 29198
		private static readonly IntPtr NativeFieldInfoPtr_lastClickPosition;

		// Token: 0x0400720F RID: 29199
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x04007210 RID: 29200
		private static readonly IntPtr NativeFieldInfoPtr_Locked;

		// Token: 0x04007211 RID: 29201
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04007212 RID: 29202
		private static readonly IntPtr NativeFieldInfoPtr_RaisedTransform;

		// Token: 0x04007213 RID: 29203
		private static readonly IntPtr NativeFieldInfoPtr_LoweredTransform;

		// Token: 0x04007214 RID: 29204
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04007215 RID: 29205
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x04007216 RID: 29206
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04007217 RID: 29207
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x04007218 RID: 29208
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04007219 RID: 29209
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x0400721A RID: 29210
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0;

		// Token: 0x0400721B RID: 29211
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0;

		// Token: 0x0400721C RID: 29212
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x0400721D RID: 29213
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x0400721E RID: 29214
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400721F RID: 29215
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007220 RID: 29216
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04007221 RID: 29217
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0;

		// Token: 0x04007222 RID: 29218
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x04007223 RID: 29219
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007224 RID: 29220
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04007225 RID: 29221
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04007226 RID: 29222
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x04007227 RID: 29223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
