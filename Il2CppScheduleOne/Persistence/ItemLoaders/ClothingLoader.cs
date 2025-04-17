using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020002C2 RID: 706
	public class ClothingLoader : ItemLoader
	{
		// Token: 0x0600321E RID: 12830 RVA: 0x0010F308 File Offset: 0x0010D508
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingLoader()
		{
			Il2CppClassPointerStore<ClothingLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.ItemLoaders", "ClothingLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingLoader>.NativeClassPtr);
			ClothingLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingLoader>.NativeClassPtr, 100668865);
			ClothingLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingLoader>.NativeClassPtr, 100668866);
			ClothingLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingLoader>.NativeClassPtr, 100668867);
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x0010F374 File Offset: 0x0010D574
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131280, XrefRangeEnd = 131287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x0010F3B8 File Offset: 0x0010D5B8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 131241, RefRangeEnd = 131261, XrefRangeStart = 131241, XrefRangeEnd = 131261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x0010F3F4 File Offset: 0x0010D5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131287, XrefRangeEnd = 131305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance LoadItem(string itemString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x0001ADDE File Offset: 0x00018FDE
		public ClothingLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0;
	}
}
