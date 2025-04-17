using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000700 RID: 1792
	public class CharacterCreatorSlider : CharacterCreatorField<float>
	{
		// Token: 0x0600A0BA RID: 41146 RVA: 0x00287418 File Offset: 0x00285618
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorSlider()
		{
			Il2CppClassPointerStore<CharacterCreatorSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorSlider>.NativeClassPtr);
			CharacterCreatorSlider.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorSlider>.NativeClassPtr, "Slider");
			CharacterCreatorSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorSlider>.NativeClassPtr, 100682956);
			CharacterCreatorSlider.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorSlider>.NativeClassPtr, 100682957);
			CharacterCreatorSlider.NativeMethodInfoPtr_OnSliderChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorSlider>.NativeClassPtr, 100682958);
			CharacterCreatorSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorSlider>.NativeClassPtr, 100682959);
		}

		// Token: 0x0600A0BB RID: 41147 RVA: 0x002874AC File Offset: 0x002856AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282542, XrefRangeEnd = 282552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BC RID: 41148 RVA: 0x002874E8 File Offset: 0x002856E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282552, XrefRangeEnd = 282557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorSlider.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BD RID: 41149 RVA: 0x00287524 File Offset: 0x00285724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282557, XrefRangeEnd = 282558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSliderChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorSlider.NativeMethodInfoPtr_OnSliderChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x00287564 File Offset: 0x00285764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282558, XrefRangeEnd = 282561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x0004F119 File Offset: 0x0004D319
		public CharacterCreatorSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0600A0C0 RID: 41152 RVA: 0x002875A0 File Offset: 0x002857A0
		// (set) Token: 0x0600A0C1 RID: 41153 RVA: 0x0004F122 File Offset: 0x0004D322
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorSlider.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorSlider.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BBD RID: 27581
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x04006BBE RID: 27582
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006BBF RID: 27583
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006BC0 RID: 27584
		private static readonly IntPtr NativeMethodInfoPtr_OnSliderChanged_Public_Void_Single_0;

		// Token: 0x04006BC1 RID: 27585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
