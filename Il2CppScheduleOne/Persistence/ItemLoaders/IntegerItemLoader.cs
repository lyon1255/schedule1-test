using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020002C4 RID: 708
	public class IntegerItemLoader : ItemLoader
	{
		// Token: 0x06003228 RID: 12840 RVA: 0x0010F598 File Offset: 0x0010D798
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemLoader()
		{
			Il2CppClassPointerStore<IntegerItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.ItemLoaders", "IntegerItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemLoader>.NativeClassPtr);
			IntegerItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemLoader>.NativeClassPtr, 100668871);
			IntegerItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemLoader>.NativeClassPtr, 100668872);
			IntegerItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemLoader>.NativeClassPtr, 100668873);
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x0010F604 File Offset: 0x0010D804
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131345, XrefRangeEnd = 131352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x0010F648 File Offset: 0x0010D848
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 131241, RefRangeEnd = 131261, XrefRangeStart = 131241, XrefRangeEnd = 131261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x0010F684 File Offset: 0x0010D884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131352, XrefRangeEnd = 131370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance LoadItem(string itemString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x0001ADF0 File Offset: 0x00018FF0
		public IntegerItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0;
	}
}
