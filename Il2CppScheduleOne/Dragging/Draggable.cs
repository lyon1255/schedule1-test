using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dragging
{
	// Token: 0x0200041D RID: 1053
	public class Draggable : MonoBehaviour
	{
		// Token: 0x06005C71 RID: 23665 RVA: 0x001ABC8C File Offset: 0x001A9E8C
		// Note: this type is marked as 'beforefieldinit'.
		static Draggable()
		{
			Il2CppClassPointerStore<Draggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dragging", "Draggable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Draggable>.NativeClassPtr);
			Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "INITIAL_REPLICATION_DISTANCE");
			Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MAX_DRAG_START_RANGE");
			Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MAX_TARGET_OFFSET");
			Draggable.NativeFieldInfoPtr__CurrentDragger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<CurrentDragger>k__BackingField");
			Draggable.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<GUID>k__BackingField");
			Draggable.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "BakedGUID");
			Draggable.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "Rigidbody");
			Draggable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "IntObj");
			Draggable.NativeFieldInfoPtr_DragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragOrigin");
			Draggable.NativeFieldInfoPtr_CreateCoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "CreateCoM");
			Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "HoldDistanceMultiplier");
			Draggable.NativeFieldInfoPtr_DragForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragForceMultiplier");
			Draggable.NativeFieldInfoPtr_InitialReplicationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "InitialReplicationMode");
			Draggable.NativeFieldInfoPtr_timeSinceLastDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "timeSinceLastDrag");
			Draggable.NativeFieldInfoPtr_onDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onDragStart");
			Draggable.NativeFieldInfoPtr_onDragEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onDragEnd");
			Draggable.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onHovered");
			Draggable.NativeFieldInfoPtr_onInteracted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onInteracted");
			Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<initialPosition>k__BackingField");
			Draggable.NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675089);
			Draggable.NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675090);
			Draggable.NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675091);
			Draggable.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675092);
			Draggable.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675093);
			Draggable.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675094);
			Draggable.NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675095);
			Draggable.NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675096);
			Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675097);
			Draggable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675098);
			Draggable.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675099);
			Draggable.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675100);
			Draggable.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675101);
			Draggable.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675102);
			Draggable.NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675103);
			Draggable.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675104);
			Draggable.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675105);
			Draggable.NativeMethodInfoPtr_CanInteract_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675106);
			Draggable.NativeMethodInfoPtr_StartDragging_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675107);
			Draggable.NativeMethodInfoPtr_StopDragging_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675108);
			Draggable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675109);
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06005C72 RID: 23666 RVA: 0x001ABFDC File Offset: 0x001AA1DC
		public unsafe bool IsBeingDragged
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 194825, RefRangeEnd = 194830, XrefRangeStart = 194821, XrefRangeEnd = 194825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06005C73 RID: 23667 RVA: 0x001AC018 File Offset: 0x001AA218
		// (set) Token: 0x06005C74 RID: 23668 RVA: 0x001AC058 File Offset: 0x001AA258
		public unsafe Player CurrentDragger
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06005C75 RID: 23669 RVA: 0x001AC09C File Offset: 0x001AA29C
		// (set) Token: 0x06005C76 RID: 23670 RVA: 0x001AC0D8 File Offset: 0x001AA2D8
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 54188, RefRangeEnd = 54192, XrefRangeStart = 54188, XrefRangeEnd = 54192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x001AC118 File Offset: 0x001AA318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194830, XrefRangeEnd = 194833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06005C78 RID: 23672 RVA: 0x001AC14C File Offset: 0x001AA34C
		// (set) Token: 0x06005C79 RID: 23673 RVA: 0x001AC188 File Offset: 0x001AA388
		public unsafe Vector3 initialPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x001AC1C8 File Offset: 0x001AA3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194833, XrefRangeEnd = 194866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x001AC204 File Offset: 0x001AA404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194866, XrefRangeEnd = 194872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x001AC240 File Offset: 0x001AA440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194876, RefRangeEnd = 194878, XrefRangeStart = 194872, XrefRangeEnd = 194876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x001AC280 File Offset: 0x001AA480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194878, XrefRangeEnd = 194893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x001AC2B4 File Offset: 0x001AA4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194893, XrefRangeEnd = 194916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x001AC2E8 File Offset: 0x001AA4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194916, XrefRangeEnd = 194937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C80 RID: 23680 RVA: 0x001AC31C File Offset: 0x001AA51C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194978, RefRangeEnd = 194980, XrefRangeStart = 194937, XrefRangeEnd = 194978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDragForces(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x001AC35C File Offset: 0x001AA55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194980, XrefRangeEnd = 194987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x001AC398 File Offset: 0x001AA598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194987, XrefRangeEnd = 194994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x001AC3D4 File Offset: 0x001AA5D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195005, RefRangeEnd = 195007, XrefRangeStart = 194994, XrefRangeEnd = 195005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_CanInteract_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x001AC410 File Offset: 0x001AA610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195014, RefRangeEnd = 195015, XrefRangeStart = 195007, XrefRangeEnd = 195014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragging(Player dragger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_StartDragging_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x001AC454 File Offset: 0x001AA654
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 195022, RefRangeEnd = 195025, XrefRangeStart = 195015, XrefRangeEnd = 195022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_StopDragging_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x001AC488 File Offset: 0x001AA688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195025, XrefRangeEnd = 195029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Draggable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Draggable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x0002B92E File Offset: 0x00029B2E
		public Draggable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06005C88 RID: 23688 RVA: 0x001AC4C4 File Offset: 0x001AA6C4
		// (set) Token: 0x06005C89 RID: 23689 RVA: 0x0002B937 File Offset: 0x00029B37
		public unsafe static float INITIAL_REPLICATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06005C8A RID: 23690 RVA: 0x001AC4E0 File Offset: 0x001AA6E0
		// (set) Token: 0x06005C8B RID: 23691 RVA: 0x0002B945 File Offset: 0x00029B45
		public unsafe static float MAX_DRAG_START_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x001AC4FC File Offset: 0x001AA6FC
		// (set) Token: 0x06005C8D RID: 23693 RVA: 0x0002B953 File Offset: 0x00029B53
		public unsafe static float MAX_TARGET_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x001AC518 File Offset: 0x001AA718
		// (set) Token: 0x06005C8F RID: 23695 RVA: 0x0002B961 File Offset: 0x00029B61
		public unsafe Player _CurrentDragger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__CurrentDragger_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__CurrentDragger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06005C90 RID: 23696 RVA: 0x001AC548 File Offset: 0x001AA748
		// (set) Token: 0x06005C91 RID: 23697 RVA: 0x0002B980 File Offset: 0x00029B80
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06005C92 RID: 23698 RVA: 0x001AC570 File Offset: 0x001AA770
		// (set) Token: 0x06005C93 RID: 23699 RVA: 0x0002B99B File Offset: 0x00029B9B
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06005C94 RID: 23700 RVA: 0x001AC598 File Offset: 0x001AA798
		// (set) Token: 0x06005C95 RID: 23701 RVA: 0x0002B9BA File Offset: 0x00029BBA
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06005C96 RID: 23702 RVA: 0x001AC5C8 File Offset: 0x001AA7C8
		// (set) Token: 0x06005C97 RID: 23703 RVA: 0x0002B9D9 File Offset: 0x00029BD9
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06005C98 RID: 23704 RVA: 0x001AC5F8 File Offset: 0x001AA7F8
		// (set) Token: 0x06005C99 RID: 23705 RVA: 0x0002B9F8 File Offset: 0x00029BF8
		public unsafe Transform DragOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06005C9A RID: 23706 RVA: 0x001AC628 File Offset: 0x001AA828
		// (set) Token: 0x06005C9B RID: 23707 RVA: 0x0002BA17 File Offset: 0x00029C17
		public unsafe bool CreateCoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CreateCoM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CreateCoM)) = value;
			}
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06005C9C RID: 23708 RVA: 0x001AC650 File Offset: 0x001AA850
		// (set) Token: 0x06005C9D RID: 23709 RVA: 0x0002BA32 File Offset: 0x00029C32
		public unsafe float HoldDistanceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier)) = value;
			}
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06005C9E RID: 23710 RVA: 0x001AC678 File Offset: 0x001AA878
		// (set) Token: 0x06005C9F RID: 23711 RVA: 0x0002BA4D File Offset: 0x00029C4D
		public unsafe float DragForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier)) = value;
			}
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06005CA0 RID: 23712 RVA: 0x001AC6A0 File Offset: 0x001AA8A0
		// (set) Token: 0x06005CA1 RID: 23713 RVA: 0x0002BA68 File Offset: 0x00029C68
		public unsafe Draggable.EInitialReplicationMode InitialReplicationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_InitialReplicationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_InitialReplicationMode)) = value;
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06005CA2 RID: 23714 RVA: 0x001AC6C8 File Offset: 0x001AA8C8
		// (set) Token: 0x06005CA3 RID: 23715 RVA: 0x0002BA83 File Offset: 0x00029C83
		public unsafe float timeSinceLastDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_timeSinceLastDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_timeSinceLastDrag)) = value;
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06005CA4 RID: 23716 RVA: 0x001AC6F0 File Offset: 0x001AA8F0
		// (set) Token: 0x06005CA5 RID: 23717 RVA: 0x0002BA9E File Offset: 0x00029C9E
		public unsafe UnityEvent onDragStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06005CA6 RID: 23718 RVA: 0x001AC720 File Offset: 0x001AA920
		// (set) Token: 0x06005CA7 RID: 23719 RVA: 0x0002BABD File Offset: 0x00029CBD
		public unsafe UnityEvent onDragEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06005CA8 RID: 23720 RVA: 0x001AC750 File Offset: 0x001AA950
		// (set) Token: 0x06005CA9 RID: 23721 RVA: 0x0002BADC File Offset: 0x00029CDC
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06005CAA RID: 23722 RVA: 0x001AC780 File Offset: 0x001AA980
		// (set) Token: 0x06005CAB RID: 23723 RVA: 0x0002BAFB File Offset: 0x00029CFB
		public unsafe UnityEvent onInteracted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onInteracted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onInteracted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06005CAC RID: 23724 RVA: 0x001AC7B0 File Offset: 0x001AA9B0
		// (set) Token: 0x06005CAD RID: 23725 RVA: 0x0002BB1A File Offset: 0x00029D1A
		public unsafe Vector3 _initialPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x04003F3D RID: 16189
		private static readonly IntPtr NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE;

		// Token: 0x04003F3E RID: 16190
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DRAG_START_RANGE;

		// Token: 0x04003F3F RID: 16191
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TARGET_OFFSET;

		// Token: 0x04003F40 RID: 16192
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDragger_k__BackingField;

		// Token: 0x04003F41 RID: 16193
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003F42 RID: 16194
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04003F43 RID: 16195
		private static readonly IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x04003F44 RID: 16196
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04003F45 RID: 16197
		private static readonly IntPtr NativeFieldInfoPtr_DragOrigin;

		// Token: 0x04003F46 RID: 16198
		private static readonly IntPtr NativeFieldInfoPtr_CreateCoM;

		// Token: 0x04003F47 RID: 16199
		private static readonly IntPtr NativeFieldInfoPtr_HoldDistanceMultiplier;

		// Token: 0x04003F48 RID: 16200
		private static readonly IntPtr NativeFieldInfoPtr_DragForceMultiplier;

		// Token: 0x04003F49 RID: 16201
		private static readonly IntPtr NativeFieldInfoPtr_InitialReplicationMode;

		// Token: 0x04003F4A RID: 16202
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastDrag;

		// Token: 0x04003F4B RID: 16203
		private static readonly IntPtr NativeFieldInfoPtr_onDragStart;

		// Token: 0x04003F4C RID: 16204
		private static readonly IntPtr NativeFieldInfoPtr_onDragEnd;

		// Token: 0x04003F4D RID: 16205
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x04003F4E RID: 16206
		private static readonly IntPtr NativeFieldInfoPtr_onInteracted;

		// Token: 0x04003F4F RID: 16207
		private static readonly IntPtr NativeFieldInfoPtr__initialPosition_k__BackingField;

		// Token: 0x04003F50 RID: 16208
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0;

		// Token: 0x04003F51 RID: 16209
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0;

		// Token: 0x04003F52 RID: 16210
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0;

		// Token: 0x04003F53 RID: 16211
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003F54 RID: 16212
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003F55 RID: 16213
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04003F56 RID: 16214
		private static readonly IntPtr NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0;

		// Token: 0x04003F57 RID: 16215
		private static readonly IntPtr NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0;

		// Token: 0x04003F58 RID: 16216
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003F59 RID: 16217
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003F5A RID: 16218
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003F5B RID: 16219
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

		// Token: 0x04003F5C RID: 16220
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

		// Token: 0x04003F5D RID: 16221
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04003F5E RID: 16222
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0;

		// Token: 0x04003F5F RID: 16223
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x04003F60 RID: 16224
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0;

		// Token: 0x04003F61 RID: 16225
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Private_Boolean_0;

		// Token: 0x04003F62 RID: 16226
		private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Void_Player_0;

		// Token: 0x04003F63 RID: 16227
		private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Void_0;

		// Token: 0x04003F64 RID: 16228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009EF RID: 2543
		[OriginalName("Assembly-CSharp.dll", "", "EInitialReplicationMode")]
		public enum EInitialReplicationMode
		{
			// Token: 0x04008AEB RID: 35563
			Off,
			// Token: 0x04008AEC RID: 35564
			OnlyIfMoved,
			// Token: 0x04008AED RID: 35565
			Full
		}
	}
}
