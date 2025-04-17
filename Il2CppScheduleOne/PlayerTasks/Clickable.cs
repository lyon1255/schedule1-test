﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x020001FC RID: 508
	public class Clickable : MonoBehaviour
	{
		// Token: 0x060029C7 RID: 10695 RVA: 0x000F4FA8 File Offset: 0x000F31A8
		// Note: this type is marked as 'beforefieldinit'.
		static Clickable()
		{
			Il2CppClassPointerStore<Clickable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Clickable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clickable>.NativeClassPtr);
			Clickable.NativeFieldInfoPtr_ClickableEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "ClickableEnabled");
			Clickable.NativeFieldInfoPtr_AutoCalculateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "AutoCalculateOffset");
			Clickable.NativeFieldInfoPtr_FlattenZOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "FlattenZOffset");
			Clickable.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			Clickable.NativeFieldInfoPtr__originalHitPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<originalHitPoint>k__BackingField");
			Clickable.NativeFieldInfoPtr_onClickStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "onClickStart");
			Clickable.NativeFieldInfoPtr_onClickEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "onClickEnd");
			Clickable.NativeFieldInfoPtr__IsHeld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<IsHeld>k__BackingField");
			Clickable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_New_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668015);
			Clickable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_New_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668016);
			Clickable.NativeMethodInfoPtr_get_originalHitPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668017);
			Clickable.NativeMethodInfoPtr_set_originalHitPoint_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668018);
			Clickable.NativeMethodInfoPtr_get_IsHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668019);
			Clickable.NativeMethodInfoPtr_set_IsHeld_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668020);
			Clickable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668021);
			Clickable.NativeMethodInfoPtr_StartClick_Public_Virtual_New_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668022);
			Clickable.NativeMethodInfoPtr_EndClick_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668023);
			Clickable.NativeMethodInfoPtr_SetOriginalHitPoint_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668024);
			Clickable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668025);
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000F5154 File Offset: 0x000F3354
		// (set) Token: 0x060029C9 RID: 10697 RVA: 0x000F519C File Offset: 0x000F339C
		public unsafe virtual CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_New_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_New_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x000F51E8 File Offset: 0x000F33E8
		// (set) Token: 0x060029CB RID: 10699 RVA: 0x000F5224 File Offset: 0x000F3424
		public unsafe Vector3 originalHitPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_originalHitPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 120152, RefRangeEnd = 120155, XrefRangeStart = 120152, XrefRangeEnd = 120152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_set_originalHitPoint_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x000F5264 File Offset: 0x000F3464
		// (set) Token: 0x060029CD RID: 10701 RVA: 0x000F52A0 File Offset: 0x000F34A0
		public unsafe bool IsHeld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_IsHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50979, RefRangeEnd = 50982, XrefRangeStart = 50979, XrefRangeEnd = 50982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_set_IsHeld_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000F52E0 File Offset: 0x000F34E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120155, XrefRangeEnd = 120160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000F5314 File Offset: 0x000F3514
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120163, RefRangeEnd = 120166, XrefRangeStart = 120160, XrefRangeEnd = 120163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_StartClick_Public_Virtual_New_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000F5360 File Offset: 0x000F3560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120167, RefRangeEnd = 120168, XrefRangeStart = 120166, XrefRangeEnd = 120167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_EndClick_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000F539C File Offset: 0x000F359C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120152, RefRangeEnd = 120155, XrefRangeStart = 120152, XrefRangeEnd = 120155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOriginalHitPoint(Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_SetOriginalHitPoint_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000F53DC File Offset: 0x000F35DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120171, RefRangeEnd = 120174, XrefRangeStart = 120168, XrefRangeEnd = 120171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Clickable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Clickable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000169BB File Offset: 0x00014BBB
		public Clickable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x000F5418 File Offset: 0x000F3618
		// (set) Token: 0x060029D5 RID: 10709 RVA: 0x000169C4 File Offset: 0x00014BC4
		public unsafe bool ClickableEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_ClickableEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_ClickableEnabled)) = value;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x000F5440 File Offset: 0x000F3640
		// (set) Token: 0x060029D7 RID: 10711 RVA: 0x000169DF File Offset: 0x00014BDF
		public unsafe bool AutoCalculateOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_AutoCalculateOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_AutoCalculateOffset)) = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x000F5468 File Offset: 0x000F3668
		// (set) Token: 0x060029D9 RID: 10713 RVA: 0x000169FA File Offset: 0x00014BFA
		public unsafe bool FlattenZOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_FlattenZOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_FlattenZOffset)) = value;
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060029DA RID: 10714 RVA: 0x000F5490 File Offset: 0x000F3690
		// (set) Token: 0x060029DB RID: 10715 RVA: 0x00016A15 File Offset: 0x00014C15
		public unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x000F54B8 File Offset: 0x000F36B8
		// (set) Token: 0x060029DD RID: 10717 RVA: 0x00016A30 File Offset: 0x00014C30
		public unsafe Vector3 _originalHitPoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__originalHitPoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__originalHitPoint_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060029DE RID: 10718 RVA: 0x000F54E0 File Offset: 0x000F36E0
		// (set) Token: 0x060029DF RID: 10719 RVA: 0x00016A4B File Offset: 0x00014C4B
		public unsafe UnityEvent<RaycastHit> onClickStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x000F5510 File Offset: 0x000F3710
		// (set) Token: 0x060029E1 RID: 10721 RVA: 0x00016A6A File Offset: 0x00014C6A
		public unsafe UnityEvent onClickEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x000F5540 File Offset: 0x000F3740
		// (set) Token: 0x060029E3 RID: 10723 RVA: 0x00016A89 File Offset: 0x00014C89
		public unsafe bool _IsHeld_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__IsHeld_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__IsHeld_k__BackingField)) = value;
			}
		}

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeFieldInfoPtr_ClickableEnabled;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeFieldInfoPtr_AutoCalculateOffset;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeFieldInfoPtr_FlattenZOffset;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeFieldInfoPtr__originalHitPoint_k__BackingField;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeFieldInfoPtr_onClickStart;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeFieldInfoPtr_onClickEnd;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeFieldInfoPtr__IsHeld_k__BackingField;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_New_get_ECursorType_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_New_set_Void_ECursorType_0;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeMethodInfoPtr_get_originalHitPoint_Public_get_Vector3_0;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeMethodInfoPtr_set_originalHitPoint_Protected_set_Void_Vector3_0;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHeld_Public_get_Boolean_0;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHeld_Protected_set_Void_Boolean_0;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_New_Void_RaycastHit_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeMethodInfoPtr_EndClick_Public_Virtual_New_Void_0;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeMethodInfoPtr_SetOriginalHitPoint_Public_Void_Vector3_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
