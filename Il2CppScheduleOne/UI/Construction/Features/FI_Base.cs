using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Construction.Features
{
	// Token: 0x02000722 RID: 1826
	public class FI_Base : MonoBehaviour
	{
		// Token: 0x0600A479 RID: 42105 RVA: 0x002934A0 File Offset: 0x002916A0
		// Note: this type is marked as 'beforefieldinit'.
		static FI_Base()
		{
			Il2CppClassPointerStore<FI_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction.Features", "FI_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_Base>.NativeClassPtr);
			FI_Base.NativeFieldInfoPtr_feature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, "feature");
			FI_Base.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, "onClose");
			FI_Base.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, 100683393);
			FI_Base.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, 100683394);
			FI_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, 100683395);
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x00293534 File Offset: 0x00291734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Feature _feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_Base.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Feature_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x00293584 File Offset: 0x00291784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287523, XrefRangeEnd = 287529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_Base.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x002935C0 File Offset: 0x002917C0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FI_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x00051154 File Offset: 0x0004F354
		public FI_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600A47E RID: 42110 RVA: 0x002935FC File Offset: 0x002917FC
		// (set) Token: 0x0600A47F RID: 42111 RVA: 0x0005115D File Offset: 0x0004F35D
		public unsafe Feature feature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_feature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_feature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600A480 RID: 42112 RVA: 0x0029362C File Offset: 0x0029182C
		// (set) Token: 0x0600A481 RID: 42113 RVA: 0x0005117C File Offset: 0x0004F37C
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E42 RID: 28226
		private static readonly IntPtr NativeFieldInfoPtr_feature;

		// Token: 0x04006E43 RID: 28227
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04006E44 RID: 28228
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Feature_0;

		// Token: 0x04006E45 RID: 28229
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04006E46 RID: 28230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
