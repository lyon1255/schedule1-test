using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000669 RID: 1641
	public class ButtonRequireInputFields : MonoBehaviour
	{
		// Token: 0x0600929E RID: 37534 RVA: 0x0025CD5C File Offset: 0x0025AF5C
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonRequireInputFields()
		{
			Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ButtonRequireInputFields");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr);
			ButtonRequireInputFields.NativeFieldInfoPtr_Inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Inputs");
			ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Dropdown");
			ButtonRequireInputFields.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Button");
			ButtonRequireInputFields.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, 100681497);
			ButtonRequireInputFields.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, 100681498);
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x0025CDF0 File Offset: 0x0025AFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264649, XrefRangeEnd = 264676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092A0 RID: 37536 RVA: 0x0025CE24 File Offset: 0x0025B024
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonRequireInputFields() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x00046F64 File Offset: 0x00045164
		public ButtonRequireInputFields(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x060092A2 RID: 37538 RVA: 0x0025CE60 File Offset: 0x0025B060
		// (set) Token: 0x060092A3 RID: 37539 RVA: 0x00046F6D File Offset: 0x0004516D
		public unsafe List<ButtonRequireInputFields.Input> Inputs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Inputs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ButtonRequireInputFields.Input>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Inputs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x060092A4 RID: 37540 RVA: 0x0025CE90 File Offset: 0x0025B090
		// (set) Token: 0x060092A5 RID: 37541 RVA: 0x00046F8C File Offset: 0x0004518C
		public unsafe TMP_Dropdown Dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x060092A6 RID: 37542 RVA: 0x0025CEC0 File Offset: 0x0025B0C0
		// (set) Token: 0x060092A7 RID: 37543 RVA: 0x00046FAB File Offset: 0x000451AB
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400630B RID: 25355
		private static readonly IntPtr NativeFieldInfoPtr_Inputs;

		// Token: 0x0400630C RID: 25356
		private static readonly IntPtr NativeFieldInfoPtr_Dropdown;

		// Token: 0x0400630D RID: 25357
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x0400630E RID: 25358
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400630F RID: 25359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B50 RID: 2896
		[Serializable]
		public class Input : Il2CppSystem.Object
		{
			// Token: 0x0600D9A2 RID: 55714 RVA: 0x00339F38 File Offset: 0x00338138
			// Note: this type is marked as 'beforefieldinit'.
			static Input()
			{
				Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Input");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr);
				ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, "InputField");
				ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, "ErrorMessage");
				ButtonRequireInputFields.Input.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, 100681499);
			}

			// Token: 0x0600D9A3 RID: 55715 RVA: 0x00339FA0 File Offset: 0x003381A0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Input() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.Input.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9A4 RID: 55716 RVA: 0x00069FF6 File Offset: 0x000681F6
			public Input(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004387 RID: 17287
			// (get) Token: 0x0600D9A5 RID: 55717 RVA: 0x00339FDC File Offset: 0x003381DC
			// (set) Token: 0x0600D9A6 RID: 55718 RVA: 0x00069FFF File Offset: 0x000681FF
			public unsafe TMP_InputField InputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004388 RID: 17288
			// (get) Token: 0x0600D9A7 RID: 55719 RVA: 0x0033A00C File Offset: 0x0033820C
			// (set) Token: 0x0600D9A8 RID: 55720 RVA: 0x0006A01E File Offset: 0x0006821E
			public unsafe RectTransform ErrorMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400922C RID: 37420
			private static readonly IntPtr NativeFieldInfoPtr_InputField;

			// Token: 0x0400922D RID: 37421
			private static readonly IntPtr NativeFieldInfoPtr_ErrorMessage;

			// Token: 0x0400922E RID: 37422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
