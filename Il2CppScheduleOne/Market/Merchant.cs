using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200037D RID: 893
	public class Merchant : MonoBehaviour
	{
		// Token: 0x060045DB RID: 17883 RVA: 0x00157B2C File Offset: 0x00155D2C
		// Note: this type is marked as 'beforefieldinit'.
		static Merchant()
		{
			Il2CppClassPointerStore<Merchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "Merchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Merchant>.NativeClassPtr);
			Merchant.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "shopName");
			Merchant.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "openTime");
			Merchant.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "closeTime");
			Merchant.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "intObj");
			Merchant.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100671887);
			Merchant.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100671888);
			Merchant.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100671889);
			Merchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100671890);
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x00157BFC File Offset: 0x00155DFC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Merchant.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x00157C38 File Offset: 0x00155E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157702, XrefRangeEnd = 157714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merchant.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x00157C6C File Offset: 0x00155E6C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Merchant.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x00157CA8 File Offset: 0x00155EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Merchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Merchant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00022041 File Offset: 0x00020241
		public Merchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x00157CE4 File Offset: 0x00155EE4
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x0002204A File Offset: 0x0002024A
		public unsafe string shopName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_shopName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x00157D0C File Offset: 0x00155F0C
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x00022069 File Offset: 0x00020269
		public unsafe int openTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_openTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_openTime)) = value;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x00157D34 File Offset: 0x00155F34
		// (set) Token: 0x060045E6 RID: 17894 RVA: 0x00022084 File Offset: 0x00020284
		public unsafe int closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x00157D5C File Offset: 0x00155F5C
		// (set) Token: 0x060045E8 RID: 17896 RVA: 0x0002209F File Offset: 0x0002029F
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EE5 RID: 12005
		private static readonly IntPtr NativeFieldInfoPtr_shopName;

		// Token: 0x04002EE6 RID: 12006
		private static readonly IntPtr NativeFieldInfoPtr_openTime;

		// Token: 0x04002EE7 RID: 12007
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04002EE8 RID: 12008
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04002EE9 RID: 12009
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002EEA RID: 12010
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04002EEB RID: 12011
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x04002EEC RID: 12012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
