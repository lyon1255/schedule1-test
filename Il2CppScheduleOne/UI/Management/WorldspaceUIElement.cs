using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E1 RID: 1761
	public class WorldspaceUIElement : MonoBehaviour
	{
		// Token: 0x06009DFE RID: 40446 RVA: 0x0027F05C File Offset: 0x0027D25C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspaceUIElement()
		{
			Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "WorldspaceUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr);
			WorldspaceUIElement.NativeFieldInfoPtr_TRANSITION_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "TRANSITION_TIME");
			WorldspaceUIElement.NativeFieldInfoPtr__IsEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "<IsEnabled>k__BackingField");
			WorldspaceUIElement.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "RectTransform");
			WorldspaceUIElement.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "Container");
			WorldspaceUIElement.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "TitleLabel");
			WorldspaceUIElement.NativeFieldInfoPtr_AssignedWorkerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "AssignedWorkerDisplay");
			WorldspaceUIElement.NativeFieldInfoPtr_scaleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "scaleRoutine");
			WorldspaceUIElement.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682671);
			WorldspaceUIElement.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682672);
			WorldspaceUIElement.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682673);
			WorldspaceUIElement.NativeMethodInfoPtr_Show_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682674);
			WorldspaceUIElement.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682675);
			WorldspaceUIElement.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682676);
			WorldspaceUIElement.NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682677);
			WorldspaceUIElement.NativeMethodInfoPtr_SetInternalScale_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682678);
			WorldspaceUIElement.NativeMethodInfoPtr_SetScale_Private_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682679);
			WorldspaceUIElement.NativeMethodInfoPtr_HoverStart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682680);
			WorldspaceUIElement.NativeMethodInfoPtr_HoverEnd_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682681);
			WorldspaceUIElement.NativeMethodInfoPtr_SetAssignedNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682682);
			WorldspaceUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100682683);
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x06009DFF RID: 40447 RVA: 0x0027F21C File Offset: 0x0027D41C
		// (set) Token: 0x06009E00 RID: 40448 RVA: 0x0027F258 File Offset: 0x0027D458
		public unsafe bool IsEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x06009E01 RID: 40449 RVA: 0x0027F298 File Offset: 0x0027D498
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279689, XrefRangeEnd = 279692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06009E02 RID: 40450 RVA: 0x0027F2D4 File Offset: 0x0027D4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279692, XrefRangeEnd = 279706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_Show_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x0027F310 File Offset: 0x0027D510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279706, XrefRangeEnd = 279726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hide(Action callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x0027F360 File Offset: 0x0027D560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279726, XrefRangeEnd = 279731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x0027F39C File Offset: 0x0027D59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279745, RefRangeEnd = 279746, XrefRangeStart = 279731, XrefRangeEnd = 279745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition(Vector3 worldSpacePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpacePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E06 RID: 40454 RVA: 0x0027F3DC File Offset: 0x0027D5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279746, XrefRangeEnd = 279754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInternalScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_SetInternalScale_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E07 RID: 40455 RVA: 0x0027F428 File Offset: 0x0027D628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279783, RefRangeEnd = 279785, XrefRangeStart = 279754, XrefRangeEnd = 279783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_SetScale_Private_Void_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x0027F478 File Offset: 0x0027D678
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_HoverStart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E09 RID: 40457 RVA: 0x0027F4B4 File Offset: 0x0027D6B4
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_HoverEnd_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E0A RID: 40458 RVA: 0x0027F4F0 File Offset: 0x0027D6F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 279793, RefRangeEnd = 279801, XrefRangeStart = 279785, XrefRangeEnd = 279793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAssignedNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_SetAssignedNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E0B RID: 40459 RVA: 0x0027F534 File Offset: 0x0027D734
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspaceUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x0004D80B File Offset: 0x0004BA0B
		public WorldspaceUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x06009E0D RID: 40461 RVA: 0x0027F570 File Offset: 0x0027D770
		// (set) Token: 0x06009E0E RID: 40462 RVA: 0x0004D814 File Offset: 0x0004BA14
		public unsafe static float TRANSITION_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspaceUIElement.NativeFieldInfoPtr_TRANSITION_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspaceUIElement.NativeFieldInfoPtr_TRANSITION_TIME, (void*)(&value));
			}
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x06009E0F RID: 40463 RVA: 0x0027F58C File Offset: 0x0027D78C
		// (set) Token: 0x06009E10 RID: 40464 RVA: 0x0004D822 File Offset: 0x0004BA22
		public unsafe bool _IsEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr__IsEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr__IsEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x06009E11 RID: 40465 RVA: 0x0027F5B4 File Offset: 0x0027D7B4
		// (set) Token: 0x06009E12 RID: 40466 RVA: 0x0004D83D File Offset: 0x0004BA3D
		public unsafe RectTransform RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x06009E13 RID: 40467 RVA: 0x0027F5E4 File Offset: 0x0027D7E4
		// (set) Token: 0x06009E14 RID: 40468 RVA: 0x0004D85C File Offset: 0x0004BA5C
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x06009E15 RID: 40469 RVA: 0x0027F614 File Offset: 0x0027D814
		// (set) Token: 0x06009E16 RID: 40470 RVA: 0x0004D87B File Offset: 0x0004BA7B
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x06009E17 RID: 40471 RVA: 0x0027F644 File Offset: 0x0027D844
		// (set) Token: 0x06009E18 RID: 40472 RVA: 0x0004D89A File Offset: 0x0004BA9A
		public unsafe AssignedWorkerDisplay AssignedWorkerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_AssignedWorkerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignedWorkerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_AssignedWorkerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x06009E19 RID: 40473 RVA: 0x0027F674 File Offset: 0x0027D874
		// (set) Token: 0x06009E1A RID: 40474 RVA: 0x0004D8B9 File Offset: 0x0004BAB9
		public unsafe Coroutine scaleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_scaleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_scaleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A11 RID: 27153
		private static readonly IntPtr NativeFieldInfoPtr_TRANSITION_TIME;

		// Token: 0x04006A12 RID: 27154
		private static readonly IntPtr NativeFieldInfoPtr__IsEnabled_k__BackingField;

		// Token: 0x04006A13 RID: 27155
		private static readonly IntPtr NativeFieldInfoPtr_RectTransform;

		// Token: 0x04006A14 RID: 27156
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006A15 RID: 27157
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006A16 RID: 27158
		private static readonly IntPtr NativeFieldInfoPtr_AssignedWorkerDisplay;

		// Token: 0x04006A17 RID: 27159
		private static readonly IntPtr NativeFieldInfoPtr_scaleRoutine;

		// Token: 0x04006A18 RID: 27160
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x04006A19 RID: 27161
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04006A1A RID: 27162
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04006A1B RID: 27163
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Virtual_New_Void_0;

		// Token: 0x04006A1C RID: 27164
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Action_0;

		// Token: 0x04006A1D RID: 27165
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04006A1E RID: 27166
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector3_0;

		// Token: 0x04006A1F RID: 27167
		private static readonly IntPtr NativeMethodInfoPtr_SetInternalScale_Public_Virtual_New_Void_Single_0;

		// Token: 0x04006A20 RID: 27168
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Private_Void_Single_Action_0;

		// Token: 0x04006A21 RID: 27169
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Public_Virtual_New_Void_0;

		// Token: 0x04006A22 RID: 27170
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Public_Virtual_New_Void_0;

		// Token: 0x04006A23 RID: 27171
		private static readonly IntPtr NativeMethodInfoPtr_SetAssignedNPC_Public_Void_NPC_0;

		// Token: 0x04006A24 RID: 27172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B98 RID: 2968
		[ObfuscatedName("ScheduleOne.UI.Management.WorldspaceUIElement+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC33 RID: 56371 RVA: 0x0034148C File Offset: 0x0033F68C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr);
				WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, "callback");
				WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, 100682684);
				WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Hide_b__0_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, 100682685);
				WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, 100682686);
			}

			// Token: 0x0600DC34 RID: 56372 RVA: 0x0034151C File Offset: 0x0033F71C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC35 RID: 56373 RVA: 0x00341558 File Offset: 0x0033F758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279664, XrefRangeEnd = 279666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Hide_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Hide_b__0_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC36 RID: 56374 RVA: 0x0034158C File Offset: 0x0033F78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC37 RID: 56375 RVA: 0x0006B411 File Offset: 0x00069611
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443E RID: 17470
			// (get) Token: 0x0600DC38 RID: 56376 RVA: 0x003415C0 File Offset: 0x0033F7C0
			// (set) Token: 0x0600DC39 RID: 56377 RVA: 0x0006B41A File Offset: 0x0006961A
			public unsafe WorldspaceUIElement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443F RID: 17471
			// (get) Token: 0x0600DC3A RID: 56378 RVA: 0x003415F0 File Offset: 0x0033F7F0
			// (set) Token: 0x0600DC3B RID: 56379 RVA: 0x0006B439 File Offset: 0x00069639
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009396 RID: 37782
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009397 RID: 37783
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04009398 RID: 37784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009399 RID: 37785
			private static readonly IntPtr NativeMethodInfoPtr__Hide_b__0_Internal_Void_1;

			// Token: 0x0400939A RID: 37786
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000B99 RID: 2969
		[ObfuscatedName("ScheduleOne.UI.Management.WorldspaceUIElement+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC3C RID: 56380 RVA: 0x00341620 File Offset: 0x0033F820
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr);
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "startScale");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "scale");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "lerpTime");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "callback");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, 100682687);
				WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, 100682688);
			}

			// Token: 0x0600DC3D RID: 56381 RVA: 0x003416D8 File Offset: 0x0033F8D8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC3E RID: 56382 RVA: 0x00341714 File Offset: 0x0033F914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279684, XrefRangeEnd = 279689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DC3F RID: 56383 RVA: 0x0006B458 File Offset: 0x00069658
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004440 RID: 17472
			// (get) Token: 0x0600DC40 RID: 56384 RVA: 0x00341754 File Offset: 0x0033F954
			// (set) Token: 0x0600DC41 RID: 56385 RVA: 0x0006B461 File Offset: 0x00069661
			public unsafe WorldspaceUIElement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004441 RID: 17473
			// (get) Token: 0x0600DC42 RID: 56386 RVA: 0x00341784 File Offset: 0x0033F984
			// (set) Token: 0x0600DC43 RID: 56387 RVA: 0x0006B480 File Offset: 0x00069680
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17004442 RID: 17474
			// (get) Token: 0x0600DC44 RID: 56388 RVA: 0x003417AC File Offset: 0x0033F9AC
			// (set) Token: 0x0600DC45 RID: 56389 RVA: 0x0006B49B File Offset: 0x0006969B
			public unsafe float scale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_scale)) = value;
				}
			}

			// Token: 0x17004443 RID: 17475
			// (get) Token: 0x0600DC46 RID: 56390 RVA: 0x003417D4 File Offset: 0x0033F9D4
			// (set) Token: 0x0600DC47 RID: 56391 RVA: 0x0006B4B6 File Offset: 0x000696B6
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004444 RID: 17476
			// (get) Token: 0x0600DC48 RID: 56392 RVA: 0x003417FC File Offset: 0x0033F9FC
			// (set) Token: 0x0600DC49 RID: 56393 RVA: 0x0006B4D1 File Offset: 0x000696D1
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400939B RID: 37787
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400939C RID: 37788
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x0400939D RID: 37789
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x0400939E RID: 37790
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400939F RID: 37791
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040093A0 RID: 37792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093A1 RID: 37793
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C80 RID: 3200
			[ObfuscatedName("ScheduleOne.UI.Management.WorldspaceUIElement+<>c__DisplayClass17_0+<<SetScale>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E662 RID: 58978 RVA: 0x0035E9BC File Offset: 0x0035CBBC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "<<SetScale>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682689);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682690);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682691);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682692);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682693);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682694);
				}

				// Token: 0x0600E663 RID: 58979 RVA: 0x0035EAB0 File Offset: 0x0035CCB0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E664 RID: 58980 RVA: 0x0035EAF8 File Offset: 0x0035CCF8
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E665 RID: 58981 RVA: 0x0035EB2C File Offset: 0x0035CD2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279666, XrefRangeEnd = 279679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047BC RID: 18364
				// (get) Token: 0x0600E666 RID: 58982 RVA: 0x0035EB68 File Offset: 0x0035CD68
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E667 RID: 58983 RVA: 0x0035EBA8 File Offset: 0x0035CDA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279679, XrefRangeEnd = 279684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047BD RID: 18365
				// (get) Token: 0x0600E668 RID: 58984 RVA: 0x0035EBDC File Offset: 0x0035CDDC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E669 RID: 58985 RVA: 0x0007072A File Offset: 0x0006E92A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047B8 RID: 18360
				// (get) Token: 0x0600E66A RID: 58986 RVA: 0x0035EC1C File Offset: 0x0035CE1C
				// (set) Token: 0x0600E66B RID: 58987 RVA: 0x00070733 File Offset: 0x0006E933
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047B9 RID: 18361
				// (get) Token: 0x0600E66C RID: 58988 RVA: 0x0035EC44 File Offset: 0x0035CE44
				// (set) Token: 0x0600E66D RID: 58989 RVA: 0x0007074E File Offset: 0x0006E94E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047BA RID: 18362
				// (get) Token: 0x0600E66E RID: 58990 RVA: 0x0035EC74 File Offset: 0x0035CE74
				// (set) Token: 0x0600E66F RID: 58991 RVA: 0x0007076D File Offset: 0x0006E96D
				public unsafe WorldspaceUIElement.__c__DisplayClass17_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement.__c__DisplayClass17_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047BB RID: 18363
				// (get) Token: 0x0600E670 RID: 58992 RVA: 0x0035ECA4 File Offset: 0x0035CEA4
				// (set) Token: 0x0600E671 RID: 58993 RVA: 0x0007078C File Offset: 0x0006E98C
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x040099FB RID: 39419
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099FC RID: 39420
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099FD RID: 39421
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099FE RID: 39422
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x040099FF RID: 39423
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A00 RID: 39424
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A01 RID: 39425
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A02 RID: 39426
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A03 RID: 39427
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A04 RID: 39428
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
