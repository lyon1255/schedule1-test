using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000746 RID: 1862
	public class LabOvenButton : MonoBehaviour
	{
		// Token: 0x0600AE85 RID: 44677 RVA: 0x002B9138 File Offset: 0x002B7338
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenButton()
		{
			Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr);
			LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "<Pressed>k__BackingField");
			LabOvenButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Button");
			LabOvenButton.NativeFieldInfoPtr_PressedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "PressedTransform");
			LabOvenButton.NativeFieldInfoPtr_DepressedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "DepressedTransform");
			LabOvenButton.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Light");
			LabOvenButton.NativeFieldInfoPtr_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Clickable");
			LabOvenButton.NativeFieldInfoPtr_pressCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "pressCoroutine");
			LabOvenButton.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684765);
			LabOvenButton.NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684766);
			LabOvenButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684767);
			LabOvenButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684768);
			LabOvenButton.NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684769);
			LabOvenButton.NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684770);
			LabOvenButton.NativeMethodInfoPtr_MoveButton_Private_IEnumerator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684771);
			LabOvenButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684772);
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x002B9294 File Offset: 0x002B7494
		// (set) Token: 0x0600AE87 RID: 44679 RVA: 0x002B92D0 File Offset: 0x002B74D0
		public unsafe bool Pressed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AE88 RID: 44680 RVA: 0x002B9310 File Offset: 0x002B7510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302040, XrefRangeEnd = 302050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE89 RID: 44681 RVA: 0x002B9344 File Offset: 0x002B7544
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302050, RefRangeEnd = 302055, XrefRangeStart = 302050, XrefRangeEnd = 302050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE8A RID: 44682 RVA: 0x002B9384 File Offset: 0x002B7584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302055, XrefRangeEnd = 302056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Press(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE8B RID: 44683 RVA: 0x002B93C4 File Offset: 0x002B75C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 302063, RefRangeEnd = 302067, XrefRangeStart = 302056, XrefRangeEnd = 302063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPressed(bool pressed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pressed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE8C RID: 44684 RVA: 0x002B9404 File Offset: 0x002B7604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302073, RefRangeEnd = 302074, XrefRangeStart = 302067, XrefRangeEnd = 302073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MoveButton(Transform destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_MoveButton_Private_IEnumerator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600AE8D RID: 44685 RVA: 0x002B9454 File Offset: 0x002B7654
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE8E RID: 44686 RVA: 0x00055BBE File Offset: 0x00053DBE
		public LabOvenButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600AE8F RID: 44687 RVA: 0x002B9490 File Offset: 0x002B7690
		// (set) Token: 0x0600AE90 RID: 44688 RVA: 0x00055BC7 File Offset: 0x00053DC7
		public unsafe bool _Pressed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField)) = value;
			}
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0600AE91 RID: 44689 RVA: 0x002B94B8 File Offset: 0x002B76B8
		// (set) Token: 0x0600AE92 RID: 44690 RVA: 0x00055BE2 File Offset: 0x00053DE2
		public unsafe Transform Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0600AE93 RID: 44691 RVA: 0x002B94E8 File Offset: 0x002B76E8
		// (set) Token: 0x0600AE94 RID: 44692 RVA: 0x00055C01 File Offset: 0x00053E01
		public unsafe Transform PressedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_PressedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_PressedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600AE95 RID: 44693 RVA: 0x002B9518 File Offset: 0x002B7718
		// (set) Token: 0x0600AE96 RID: 44694 RVA: 0x00055C20 File Offset: 0x00053E20
		public unsafe Transform DepressedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_DepressedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_DepressedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600AE97 RID: 44695 RVA: 0x002B9548 File Offset: 0x002B7748
		// (set) Token: 0x0600AE98 RID: 44696 RVA: 0x00055C3F File Offset: 0x00053E3F
		public unsafe ToggleableLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600AE99 RID: 44697 RVA: 0x002B9578 File Offset: 0x002B7778
		// (set) Token: 0x0600AE9A RID: 44698 RVA: 0x00055C5E File Offset: 0x00053E5E
		public unsafe Clickable Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0600AE9B RID: 44699 RVA: 0x002B95A8 File Offset: 0x002B77A8
		// (set) Token: 0x0600AE9C RID: 44700 RVA: 0x00055C7D File Offset: 0x00053E7D
		public unsafe Coroutine pressCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_pressCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_pressCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400757E RID: 30078
		private static readonly IntPtr NativeFieldInfoPtr__Pressed_k__BackingField;

		// Token: 0x0400757F RID: 30079
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04007580 RID: 30080
		private static readonly IntPtr NativeFieldInfoPtr_PressedTransform;

		// Token: 0x04007581 RID: 30081
		private static readonly IntPtr NativeFieldInfoPtr_DepressedTransform;

		// Token: 0x04007582 RID: 30082
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04007583 RID: 30083
		private static readonly IntPtr NativeFieldInfoPtr_Clickable;

		// Token: 0x04007584 RID: 30084
		private static readonly IntPtr NativeFieldInfoPtr_pressCoroutine;

		// Token: 0x04007585 RID: 30085
		private static readonly IntPtr NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0;

		// Token: 0x04007586 RID: 30086
		private static readonly IntPtr NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0;

		// Token: 0x04007587 RID: 30087
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007588 RID: 30088
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007589 RID: 30089
		private static readonly IntPtr NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0;

		// Token: 0x0400758A RID: 30090
		private static readonly IntPtr NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0;

		// Token: 0x0400758B RID: 30091
		private static readonly IntPtr NativeMethodInfoPtr_MoveButton_Private_IEnumerator_Transform_0;

		// Token: 0x0400758C RID: 30092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BEE RID: 3054
		[ObfuscatedName("ScheduleOne.ObjectScripts.LabOvenButton+<MoveButton>d__14")]
		public sealed class _MoveButton_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600DF3E RID: 57150 RVA: 0x00349DD0 File Offset: 0x00347FD0
			// Note: this type is marked as 'beforefieldinit'.
			static _MoveButton_d__14()
			{
				Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "<MoveButton>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr);
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<>1__state");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<>2__current");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<>4__this");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "destination");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<startPos>5__2");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__endPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<endPos>5__3");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<lerpTime>5__4");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__t_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<t>5__5");
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684773);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684774);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684775);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684776);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684777);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684778);
			}

			// Token: 0x0600DF3F RID: 57151 RVA: 0x00349F14 File Offset: 0x00348114
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MoveButton_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF40 RID: 57152 RVA: 0x00349F5C File Offset: 0x0034815C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF41 RID: 57153 RVA: 0x00349F90 File Offset: 0x00348190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302028, XrefRangeEnd = 302035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004535 RID: 17717
			// (get) Token: 0x0600DF42 RID: 57154 RVA: 0x00349FCC File Offset: 0x003481CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF43 RID: 57155 RVA: 0x0034A00C File Offset: 0x0034820C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302035, XrefRangeEnd = 302040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004536 RID: 17718
			// (get) Token: 0x0600DF44 RID: 57156 RVA: 0x0034A040 File Offset: 0x00348240
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF45 RID: 57157 RVA: 0x0006CD65 File Offset: 0x0006AF65
			public _MoveButton_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700452D RID: 17709
			// (get) Token: 0x0600DF46 RID: 57158 RVA: 0x0034A080 File Offset: 0x00348280
			// (set) Token: 0x0600DF47 RID: 57159 RVA: 0x0006CD6E File Offset: 0x0006AF6E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700452E RID: 17710
			// (get) Token: 0x0600DF48 RID: 57160 RVA: 0x0034A0A8 File Offset: 0x003482A8
			// (set) Token: 0x0600DF49 RID: 57161 RVA: 0x0006CD89 File Offset: 0x0006AF89
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452F RID: 17711
			// (get) Token: 0x0600DF4A RID: 57162 RVA: 0x0034A0D8 File Offset: 0x003482D8
			// (set) Token: 0x0600DF4B RID: 57163 RVA: 0x0006CDA8 File Offset: 0x0006AFA8
			public unsafe LabOvenButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004530 RID: 17712
			// (get) Token: 0x0600DF4C RID: 57164 RVA: 0x0034A108 File Offset: 0x00348308
			// (set) Token: 0x0600DF4D RID: 57165 RVA: 0x0006CDC7 File Offset: 0x0006AFC7
			public unsafe Transform destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004531 RID: 17713
			// (get) Token: 0x0600DF4E RID: 57166 RVA: 0x0034A138 File Offset: 0x00348338
			// (set) Token: 0x0600DF4F RID: 57167 RVA: 0x0006CDE6 File Offset: 0x0006AFE6
			public unsafe Vector3 _startPos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__startPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__startPos_5__2)) = value;
				}
			}

			// Token: 0x17004532 RID: 17714
			// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x0034A160 File Offset: 0x00348360
			// (set) Token: 0x0600DF51 RID: 57169 RVA: 0x0006CE01 File Offset: 0x0006B001
			public unsafe Vector3 _endPos_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__endPos_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__endPos_5__3)) = value;
				}
			}

			// Token: 0x17004533 RID: 17715
			// (get) Token: 0x0600DF52 RID: 57170 RVA: 0x0034A188 File Offset: 0x00348388
			// (set) Token: 0x0600DF53 RID: 57171 RVA: 0x0006CE1C File Offset: 0x0006B01C
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x17004534 RID: 17716
			// (get) Token: 0x0600DF54 RID: 57172 RVA: 0x0034A1B0 File Offset: 0x003483B0
			// (set) Token: 0x0600DF55 RID: 57173 RVA: 0x0006CE37 File Offset: 0x0006B037
			public unsafe float _t_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__t_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__t_5__5)) = value;
				}
			}

			// Token: 0x04009587 RID: 38279
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009588 RID: 38280
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009589 RID: 38281
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400958A RID: 38282
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x0400958B RID: 38283
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__2;

			// Token: 0x0400958C RID: 38284
			private static readonly IntPtr NativeFieldInfoPtr__endPos_5__3;

			// Token: 0x0400958D RID: 38285
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x0400958E RID: 38286
			private static readonly IntPtr NativeFieldInfoPtr__t_5__5;

			// Token: 0x0400958F RID: 38287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009590 RID: 38288
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009591 RID: 38289
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009592 RID: 38290
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009593 RID: 38291
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009594 RID: 38292
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
