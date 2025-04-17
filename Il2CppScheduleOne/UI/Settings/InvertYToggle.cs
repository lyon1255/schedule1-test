using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200068C RID: 1676
	public class InvertYToggle : SettingsToggle
	{
		// Token: 0x060095D1 RID: 38353 RVA: 0x00266560 File Offset: 0x00264760
		// Note: this type is marked as 'beforefieldinit'.
		static InvertYToggle()
		{
			Il2CppClassPointerStore<InvertYToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "InvertYToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvertYToggle>.NativeClassPtr);
			InvertYToggle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertYToggle>.NativeClassPtr, 100681811);
			InvertYToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertYToggle>.NativeClassPtr, 100681812);
			InvertYToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertYToggle>.NativeClassPtr, 100681813);
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x002665CC File Offset: 0x002647CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268832, XrefRangeEnd = 268838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvertYToggle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x00266608 File Offset: 0x00264808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268838, XrefRangeEnd = 268854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvertYToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D4 RID: 38356 RVA: 0x00266654 File Offset: 0x00264854
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvertYToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvertYToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvertYToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x00048CB7 File Offset: 0x00046EB7
		public InvertYToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006503 RID: 25859
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006504 RID: 25860
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04006505 RID: 25861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
