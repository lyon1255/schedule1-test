using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200068B RID: 1675
	public class IntefaceScaleSlider : SettingsSlider
	{
		// Token: 0x060095C5 RID: 38341 RVA: 0x0026633C File Offset: 0x0026453C
		// Note: this type is marked as 'beforefieldinit'.
		static IntefaceScaleSlider()
		{
			Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "IntefaceScaleSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr);
			IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MULTIPLIER");
			IntefaceScaleSlider.NativeFieldInfoPtr_MinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MinScale");
			IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MaxScale");
			IntefaceScaleSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100681807);
			IntefaceScaleSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100681808);
			IntefaceScaleSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100681809);
			IntefaceScaleSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100681810);
		}

		// Token: 0x060095C6 RID: 38342 RVA: 0x002663F8 File Offset: 0x002645F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268810, XrefRangeEnd = 268817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095C7 RID: 38343 RVA: 0x00266434 File Offset: 0x00264634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268817, XrefRangeEnd = 268827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095C8 RID: 38344 RVA: 0x00266480 File Offset: 0x00264680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268827, XrefRangeEnd = 268832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDisplayValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060095C9 RID: 38345 RVA: 0x002664D0 File Offset: 0x002646D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntefaceScaleSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntefaceScaleSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095CA RID: 38346 RVA: 0x00048C84 File Offset: 0x00046E84
		public IntefaceScaleSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x060095CB RID: 38347 RVA: 0x0026650C File Offset: 0x0026470C
		// (set) Token: 0x060095CC RID: 38348 RVA: 0x00048C8D File Offset: 0x00046E8D
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x060095CD RID: 38349 RVA: 0x00266528 File Offset: 0x00264728
		// (set) Token: 0x060095CE RID: 38350 RVA: 0x00048C9B File Offset: 0x00046E9B
		public unsafe static float MinScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MinScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MinScale, (void*)(&value));
			}
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x060095CF RID: 38351 RVA: 0x00266544 File Offset: 0x00264744
		// (set) Token: 0x060095D0 RID: 38352 RVA: 0x00048CA9 File Offset: 0x00046EA9
		public unsafe static float MaxScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale, (void*)(&value));
			}
		}

		// Token: 0x040064FC RID: 25852
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x040064FD RID: 25853
		private static readonly IntPtr NativeFieldInfoPtr_MinScale;

		// Token: 0x040064FE RID: 25854
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x040064FF RID: 25855
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04006500 RID: 25856
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x04006501 RID: 25857
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0;

		// Token: 0x04006502 RID: 25858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
