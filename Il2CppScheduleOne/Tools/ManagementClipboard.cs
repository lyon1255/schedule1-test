using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000527 RID: 1319
	public class ManagementClipboard : Singleton<ManagementClipboard>
	{
		// Token: 0x060075E1 RID: 30177 RVA: 0x002017A4 File Offset: 0x001FF9A4
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementClipboard()
		{
			Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ManagementClipboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr);
			ManagementClipboard.NativeFieldInfoPtr_IsEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "IsEquipped");
			ManagementClipboard.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "<IsOpen>k__BackingField");
			ManagementClipboard.NativeFieldInfoPtr__StatePreserved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "<StatePreserved>k__BackingField");
			ManagementClipboard.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "OpenTime");
			ManagementClipboard.NativeFieldInfoPtr_ClipboardTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "ClipboardTransform");
			ManagementClipboard.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "OverlayCamera");
			ManagementClipboard.NativeFieldInfoPtr_OverlayLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "OverlayLight");
			ManagementClipboard.NativeFieldInfoPtr_SelectionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "SelectionInfo");
			ManagementClipboard.NativeFieldInfoPtr_ClosedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "ClosedOffset");
			ManagementClipboard.NativeFieldInfoPtr_onClipboardEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onClipboardEquipped");
			ManagementClipboard.NativeFieldInfoPtr_onClipboardUnequipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onClipboardUnequipped");
			ManagementClipboard.NativeFieldInfoPtr_onOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onOpened");
			ManagementClipboard.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onClosed");
			ManagementClipboard.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "lerpRoutine");
			ManagementClipboard.NativeFieldInfoPtr_CurrentConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "CurrentConfigurables");
			ManagementClipboard.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678154);
			ManagementClipboard.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678155);
			ManagementClipboard.NativeMethodInfoPtr_get_StatePreserved_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678156);
			ManagementClipboard.NativeMethodInfoPtr_set_StatePreserved_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678157);
			ManagementClipboard.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678158);
			ManagementClipboard.NativeMethodInfoPtr_Update_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678159);
			ManagementClipboard.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678160);
			ManagementClipboard.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678161);
			ManagementClipboard.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678162);
			ManagementClipboard.NativeMethodInfoPtr_LerpToVerticalPosition_Private_Void_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678163);
			ManagementClipboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678164);
			ManagementClipboard.NativeMethodInfoPtr__Close_b__25_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678165);
			ManagementClipboard.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678166);
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x060075E2 RID: 30178 RVA: 0x00201A04 File Offset: 0x001FFC04
		// (set) Token: 0x060075E3 RID: 30179 RVA: 0x00201A40 File Offset: 0x001FFC40
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x060075E4 RID: 30180 RVA: 0x00201A80 File Offset: 0x001FFC80
		// (set) Token: 0x060075E5 RID: 30181 RVA: 0x00201ABC File Offset: 0x001FFCBC
		public unsafe bool StatePreserved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_get_StatePreserved_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_set_StatePreserved_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x00201AFC File Offset: 0x001FFCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230121, XrefRangeEnd = 230140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x00201B38 File Offset: 0x001FFD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230140, XrefRangeEnd = 230150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Update_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x00201B6C File Offset: 0x001FFD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230150, XrefRangeEnd = 230151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00201BB0 File Offset: 0x001FFDB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 230205, RefRangeEnd = 230209, XrefRangeStart = 230151, XrefRangeEnd = 230205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<IConfigurable> selection, ManagementClipboard_Equippable equippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equippable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x00201C04 File Offset: 0x001FFE04
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 230269, RefRangeEnd = 230275, XrefRangeStart = 230209, XrefRangeEnd = 230269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveState = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref preserveState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x00201C44 File Offset: 0x001FFE44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230294, RefRangeEnd = 230296, XrefRangeStart = 230275, XrefRangeEnd = 230294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpToVerticalPosition(bool open, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_LerpToVerticalPosition_Private_Void_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x00201C94 File Offset: 0x001FFE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230296, XrefRangeEnd = 230306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementClipboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x00201CD0 File Offset: 0x001FFED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230306, XrefRangeEnd = 230313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Close_b__25_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr__Close_b__25_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EE RID: 30190 RVA: 0x00201D04 File Offset: 0x001FFF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00037D22 File Offset: 0x00035F22
		public ManagementClipboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x060075F0 RID: 30192 RVA: 0x00201D38 File Offset: 0x001FFF38
		// (set) Token: 0x060075F1 RID: 30193 RVA: 0x00037D2B File Offset: 0x00035F2B
		public unsafe bool IsEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_IsEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_IsEquipped)) = value;
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x060075F2 RID: 30194 RVA: 0x00201D60 File Offset: 0x001FFF60
		// (set) Token: 0x060075F3 RID: 30195 RVA: 0x00037D46 File Offset: 0x00035F46
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x060075F4 RID: 30196 RVA: 0x00201D88 File Offset: 0x001FFF88
		// (set) Token: 0x060075F5 RID: 30197 RVA: 0x00037D61 File Offset: 0x00035F61
		public unsafe bool _StatePreserved_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__StatePreserved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__StatePreserved_k__BackingField)) = value;
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x060075F6 RID: 30198 RVA: 0x00201DB0 File Offset: 0x001FFFB0
		// (set) Token: 0x060075F7 RID: 30199 RVA: 0x00037D7C File Offset: 0x00035F7C
		public unsafe static float OpenTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementClipboard.NativeFieldInfoPtr_OpenTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementClipboard.NativeFieldInfoPtr_OpenTime, (void*)(&value));
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x060075F8 RID: 30200 RVA: 0x00201DCC File Offset: 0x001FFFCC
		// (set) Token: 0x060075F9 RID: 30201 RVA: 0x00037D8A File Offset: 0x00035F8A
		public unsafe Transform ClipboardTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClipboardTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClipboardTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x060075FA RID: 30202 RVA: 0x00201DFC File Offset: 0x001FFFFC
		// (set) Token: 0x060075FB RID: 30203 RVA: 0x00037DA9 File Offset: 0x00035FA9
		public unsafe Camera OverlayCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x060075FC RID: 30204 RVA: 0x00201E2C File Offset: 0x0020002C
		// (set) Token: 0x060075FD RID: 30205 RVA: 0x00037DC8 File Offset: 0x00035FC8
		public unsafe Light OverlayLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x060075FE RID: 30206 RVA: 0x00201E5C File Offset: 0x0020005C
		// (set) Token: 0x060075FF RID: 30207 RVA: 0x00037DE7 File Offset: 0x00035FE7
		public unsafe SelectionInfoUI SelectionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_SelectionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionInfoUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_SelectionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x06007600 RID: 30208 RVA: 0x00201E8C File Offset: 0x0020008C
		// (set) Token: 0x06007601 RID: 30209 RVA: 0x00037E06 File Offset: 0x00036006
		public unsafe float ClosedOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClosedOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClosedOffset)) = value;
			}
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x06007602 RID: 30210 RVA: 0x00201EB4 File Offset: 0x002000B4
		// (set) Token: 0x06007603 RID: 30211 RVA: 0x00037E21 File Offset: 0x00036021
		public unsafe UnityEvent onClipboardEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardEquipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x00201EE4 File Offset: 0x002000E4
		// (set) Token: 0x06007605 RID: 30213 RVA: 0x00037E40 File Offset: 0x00036040
		public unsafe UnityEvent onClipboardUnequipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardUnequipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardUnequipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x06007606 RID: 30214 RVA: 0x00201F14 File Offset: 0x00200114
		// (set) Token: 0x06007607 RID: 30215 RVA: 0x00037E5F File Offset: 0x0003605F
		public unsafe UnityEvent onOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x06007608 RID: 30216 RVA: 0x00201F44 File Offset: 0x00200144
		// (set) Token: 0x06007609 RID: 30217 RVA: 0x00037E7E File Offset: 0x0003607E
		public unsafe UnityEvent onClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x0600760A RID: 30218 RVA: 0x00201F74 File Offset: 0x00200174
		// (set) Token: 0x0600760B RID: 30219 RVA: 0x00037E9D File Offset: 0x0003609D
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x0600760C RID: 30220 RVA: 0x00201FA4 File Offset: 0x002001A4
		// (set) Token: 0x0600760D RID: 30221 RVA: 0x00037EBC File Offset: 0x000360BC
		public unsafe List<IConfigurable> CurrentConfigurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_CurrentConfigurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_CurrentConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005092 RID: 20626
		private static readonly IntPtr NativeFieldInfoPtr_IsEquipped;

		// Token: 0x04005093 RID: 20627
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005094 RID: 20628
		private static readonly IntPtr NativeFieldInfoPtr__StatePreserved_k__BackingField;

		// Token: 0x04005095 RID: 20629
		private static readonly IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04005096 RID: 20630
		private static readonly IntPtr NativeFieldInfoPtr_ClipboardTransform;

		// Token: 0x04005097 RID: 20631
		private static readonly IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x04005098 RID: 20632
		private static readonly IntPtr NativeFieldInfoPtr_OverlayLight;

		// Token: 0x04005099 RID: 20633
		private static readonly IntPtr NativeFieldInfoPtr_SelectionInfo;

		// Token: 0x0400509A RID: 20634
		private static readonly IntPtr NativeFieldInfoPtr_ClosedOffset;

		// Token: 0x0400509B RID: 20635
		private static readonly IntPtr NativeFieldInfoPtr_onClipboardEquipped;

		// Token: 0x0400509C RID: 20636
		private static readonly IntPtr NativeFieldInfoPtr_onClipboardUnequipped;

		// Token: 0x0400509D RID: 20637
		private static readonly IntPtr NativeFieldInfoPtr_onOpened;

		// Token: 0x0400509E RID: 20638
		private static readonly IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x0400509F RID: 20639
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x040050A0 RID: 20640
		private static readonly IntPtr NativeFieldInfoPtr_CurrentConfigurables;

		// Token: 0x040050A1 RID: 20641
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040050A2 RID: 20642
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040050A3 RID: 20643
		private static readonly IntPtr NativeMethodInfoPtr_get_StatePreserved_Public_get_Boolean_0;

		// Token: 0x040050A4 RID: 20644
		private static readonly IntPtr NativeMethodInfoPtr_set_StatePreserved_Protected_set_Void_Boolean_0;

		// Token: 0x040050A5 RID: 20645
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040050A6 RID: 20646
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_1;

		// Token: 0x040050A7 RID: 20647
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040050A8 RID: 20648
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0;

		// Token: 0x040050A9 RID: 20649
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x040050AA RID: 20650
		private static readonly IntPtr NativeMethodInfoPtr_LerpToVerticalPosition_Private_Void_Boolean_Action_0;

		// Token: 0x040050AB RID: 20651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040050AC RID: 20652
		private static readonly IntPtr NativeMethodInfoPtr__Close_b__25_0_Private_Void_1;

		// Token: 0x040050AD RID: 20653
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000A95 RID: 2709
		[ObfuscatedName("ScheduleOne.Tools.ManagementClipboard+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2A1 RID: 53921 RVA: 0x00325F5C File Offset: 0x0032415C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr);
				ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "startPos");
				ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "endPos");
				ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "callback");
				ManagementClipboard.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, 100678167);
				ManagementClipboard.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, 100678168);
			}

			// Token: 0x0600D2A2 RID: 53922 RVA: 0x00326000 File Offset: 0x00324200
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2A3 RID: 53923 RVA: 0x0032603C File Offset: 0x0032423C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230116, XrefRangeEnd = 230121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D2A4 RID: 53924 RVA: 0x00066864 File Offset: 0x00064A64
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004157 RID: 16727
			// (get) Token: 0x0600D2A5 RID: 53925 RVA: 0x0032607C File Offset: 0x0032427C
			// (set) Token: 0x0600D2A6 RID: 53926 RVA: 0x0006686D File Offset: 0x00064A6D
			public unsafe ManagementClipboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004158 RID: 16728
			// (get) Token: 0x0600D2A7 RID: 53927 RVA: 0x003260AC File Offset: 0x003242AC
			// (set) Token: 0x0600D2A8 RID: 53928 RVA: 0x0006688C File Offset: 0x00064A8C
			public unsafe Vector3 startPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_startPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_startPos)) = value;
				}
			}

			// Token: 0x17004159 RID: 16729
			// (get) Token: 0x0600D2A9 RID: 53929 RVA: 0x003260D4 File Offset: 0x003242D4
			// (set) Token: 0x0600D2AA RID: 53930 RVA: 0x000668A7 File Offset: 0x00064AA7
			public unsafe Vector3 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x1700415A RID: 16730
			// (get) Token: 0x0600D2AB RID: 53931 RVA: 0x003260FC File Offset: 0x003242FC
			// (set) Token: 0x0600D2AC RID: 53932 RVA: 0x000668C2 File Offset: 0x00064AC2
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E00 RID: 36352
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E01 RID: 36353
			private static readonly IntPtr NativeFieldInfoPtr_startPos;

			// Token: 0x04008E02 RID: 36354
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04008E03 RID: 36355
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04008E04 RID: 36356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E05 RID: 36357
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C61 RID: 3169
			[ObfuscatedName("ScheduleOne.Tools.ManagementClipboard+<>c__DisplayClass26_0+<<LerpToVerticalPosition>g__Lerp|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E421 RID: 58401 RVA: 0x00358104 File Offset: 0x00356304
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "<<LerpToVerticalPosition>g__Lerp|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678169);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678170);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678171);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678172);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678173);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678174);
				}

				// Token: 0x0600E422 RID: 58402 RVA: 0x003581F8 File Offset: 0x003563F8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E423 RID: 58403 RVA: 0x00358240 File Offset: 0x00356440
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E424 RID: 58404 RVA: 0x00358274 File Offset: 0x00356474
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230101, XrefRangeEnd = 230111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046DA RID: 18138
				// (get) Token: 0x0600E425 RID: 58405 RVA: 0x003582B0 File Offset: 0x003564B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E426 RID: 58406 RVA: 0x003582F0 File Offset: 0x003564F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230111, XrefRangeEnd = 230116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046DB RID: 18139
				// (get) Token: 0x0600E427 RID: 58407 RVA: 0x00358324 File Offset: 0x00356524
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E428 RID: 58408 RVA: 0x0006F3AC File Offset: 0x0006D5AC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046D6 RID: 18134
				// (get) Token: 0x0600E429 RID: 58409 RVA: 0x00358364 File Offset: 0x00356564
				// (set) Token: 0x0600E42A RID: 58410 RVA: 0x0006F3B5 File Offset: 0x0006D5B5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046D7 RID: 18135
				// (get) Token: 0x0600E42B RID: 58411 RVA: 0x0035838C File Offset: 0x0035658C
				// (set) Token: 0x0600E42C RID: 58412 RVA: 0x0006F3D0 File Offset: 0x0006D5D0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046D8 RID: 18136
				// (get) Token: 0x0600E42D RID: 58413 RVA: 0x003583BC File Offset: 0x003565BC
				// (set) Token: 0x0600E42E RID: 58414 RVA: 0x0006F3EF File Offset: 0x0006D5EF
				public unsafe ManagementClipboard.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046D9 RID: 18137
				// (get) Token: 0x0600E42F RID: 58415 RVA: 0x003583EC File Offset: 0x003565EC
				// (set) Token: 0x0600E430 RID: 58416 RVA: 0x0006F40E File Offset: 0x0006D60E
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400989C RID: 39068
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400989D RID: 39069
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400989E RID: 39070
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400989F RID: 39071
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x040098A0 RID: 39072
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098A1 RID: 39073
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098A2 RID: 39074
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098A3 RID: 39075
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098A4 RID: 39076
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098A5 RID: 39077
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
