using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI;
using UnityEngine;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200037B RID: 891
	public class BuilderMerchant : MonoBehaviour
	{
		// Token: 0x060045CA RID: 17866 RVA: 0x00157888 File Offset: 0x00155A88
		// Note: this type is marked as 'beforefieldinit'.
		static BuilderMerchant()
		{
			Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "BuilderMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr);
			BuilderMerchant.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "openTime");
			BuilderMerchant.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "closeTime");
			BuilderMerchant.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "intObj");
			BuilderMerchant.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "selector");
			BuilderMerchant.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100671882);
			BuilderMerchant.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100671883);
			BuilderMerchant.NativeMethodInfoPtr_PropertySelected_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100671884);
			BuilderMerchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100671885);
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00157958 File Offset: 0x00155B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157667, XrefRangeEnd = 157682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x0015798C File Offset: 0x00155B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157682, XrefRangeEnd = 157690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x001579C0 File Offset: 0x00155BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157690, XrefRangeEnd = 157696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertySelected(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr_PropertySelected_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x00157A04 File Offset: 0x00155C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157696, XrefRangeEnd = 157697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuilderMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x00021F82 File Offset: 0x00020182
		public BuilderMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x00157A40 File Offset: 0x00155C40
		// (set) Token: 0x060045D1 RID: 17873 RVA: 0x00021F8B File Offset: 0x0002018B
		public unsafe int openTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_openTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_openTime)) = value;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x00157A68 File Offset: 0x00155C68
		// (set) Token: 0x060045D3 RID: 17875 RVA: 0x00021FA6 File Offset: 0x000201A6
		public unsafe int closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x060045D4 RID: 17876 RVA: 0x00157A90 File Offset: 0x00155C90
		// (set) Token: 0x060045D5 RID: 17877 RVA: 0x00021FC1 File Offset: 0x000201C1
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x00157AC0 File Offset: 0x00155CC0
		// (set) Token: 0x060045D7 RID: 17879 RVA: 0x00021FE0 File Offset: 0x000201E0
		public unsafe PropertySelector selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EDC RID: 11996
		private static readonly IntPtr NativeFieldInfoPtr_openTime;

		// Token: 0x04002EDD RID: 11997
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04002EDE RID: 11998
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04002EDF RID: 11999
		private static readonly IntPtr NativeFieldInfoPtr_selector;

		// Token: 0x04002EE0 RID: 12000
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04002EE1 RID: 12001
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04002EE2 RID: 12002
		private static readonly IntPtr NativeMethodInfoPtr_PropertySelected_Private_Void_Property_0;

		// Token: 0x04002EE3 RID: 12003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
