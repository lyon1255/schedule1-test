using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020002C1 RID: 705
	public class CashLoader : ItemLoader
	{
		// Token: 0x06003219 RID: 12825 RVA: 0x0010F1C0 File Offset: 0x0010D3C0
		// Note: this type is marked as 'beforefieldinit'.
		static CashLoader()
		{
			Il2CppClassPointerStore<CashLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.ItemLoaders", "CashLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashLoader>.NativeClassPtr);
			CashLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashLoader>.NativeClassPtr, 100668862);
			CashLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashLoader>.NativeClassPtr, 100668863);
			CashLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashLoader>.NativeClassPtr, 100668864);
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x0010F22C File Offset: 0x0010D42C
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131233, XrefRangeEnd = 131240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x0010F270 File Offset: 0x0010D470
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 131241, RefRangeEnd = 131261, XrefRangeStart = 131240, XrefRangeEnd = 131241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x0010F2AC File Offset: 0x0010D4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131261, XrefRangeEnd = 131280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance LoadItem(string itemString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x0001ADD5 File Offset: 0x00018FD5
		public CashLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0;
	}
}
