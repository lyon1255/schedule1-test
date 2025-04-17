using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020002C5 RID: 709
	public class ItemLoader : Object
	{
		// Token: 0x0600322D RID: 12845 RVA: 0x0010F6E0 File Offset: 0x0010D8E0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemLoader()
		{
			Il2CppClassPointerStore<ItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.ItemLoaders", "ItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr);
			ItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100668874);
			ItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100668875);
			ItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100668876);
			ItemLoader.NativeMethodInfoPtr_LoadData_Protected_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100668877);
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x0010F760 File Offset: 0x0010D960
		public unsafe virtual string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131370, XrefRangeEnd = 131377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x0010F7A4 File Offset: 0x0010D9A4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 131388, RefRangeEnd = 131400, XrefRangeStart = 131377, XrefRangeEnd = 131388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x0010F7E0 File Offset: 0x0010D9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131400, XrefRangeEnd = 131418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance LoadItem(string itemString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x0010F83C File Offset: 0x0010DA3C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 131428, RefRangeEnd = 131439, XrefRangeStart = 131418, XrefRangeEnd = 131428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T LoadData<T>(string itemString) where T : ItemData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemLoader.MethodInfoStoreGeneric_LoadData_Protected_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x0001ADF9 File Offset: 0x00018FF9
		public ItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeMethodInfoPtr_LoadData_Protected_T_String_0;

		// Token: 0x02000919 RID: 2329
		private sealed class MethodInfoStoreGeneric_LoadData_Protected_T_String_0<T>
		{
			// Token: 0x04008623 RID: 34339
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ItemLoader.NativeMethodInfoPtr_LoadData_Protected_T_String_0, Il2CppClassPointerStore<ItemLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
