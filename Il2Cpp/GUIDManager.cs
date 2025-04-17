using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2Cpp
{
	// Token: 0x0200000E RID: 14
	public static class GUIDManager : Object
	{
		// Token: 0x06000131 RID: 305 RVA: 0x000745A4 File Offset: 0x000727A4
		// Note: this type is marked as 'beforefieldinit'.
		static GUIDManager()
		{
			Il2CppClassPointerStore<GUIDManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GUIDManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr);
			GUIDManager.NativeFieldInfoPtr_registeredGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, "registeredGUIDs");
			GUIDManager.NativeFieldInfoPtr_guidToObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, "guidToObject");
			GUIDManager.NativeMethodInfoPtr_RegisterObject_Public_Static_Void_IGUIDRegisterable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663375);
			GUIDManager.NativeMethodInfoPtr_DeregisterObject_Public_Static_Void_IGUIDRegisterable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663376);
			GUIDManager.NativeMethodInfoPtr_GetObject_Public_Static_T_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663377);
			GUIDManager.NativeMethodInfoPtr_GetObjectType_Public_Static_Type_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663378);
			GUIDManager.NativeMethodInfoPtr_GenerateUniqueGUID_Public_Static_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663379);
			GUIDManager.NativeMethodInfoPtr_IsGUIDAlreadyRegistered_Public_Static_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663380);
			GUIDManager.NativeMethodInfoPtr_IsGUIDValid_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663381);
			GUIDManager.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663382);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0007469C File Offset: 0x0007289C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 71505, RefRangeEnd = 71540, XrefRangeStart = 71456, XrefRangeEnd = 71505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterObject(IGUIDRegisterable obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_RegisterObject_Public_Static_Void_IGUIDRegisterable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000746D4 File Offset: 0x000728D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71556, RefRangeEnd = 71557, XrefRangeStart = 71540, XrefRangeEnd = 71556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeregisterObject(IGUIDRegisterable obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_DeregisterObject_Public_Static_Void_IGUIDRegisterable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0007470C File Offset: 0x0007290C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 71582, RefRangeEnd = 71632, XrefRangeStart = 71557, XrefRangeEnd = 71582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetObject<T>(Guid guid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.MethodInfoStoreGeneric_GetObject_Public_Static_T_Guid_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00074748 File Offset: 0x00072948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71632, XrefRangeEnd = 71639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetObjectType(Guid guid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_GetObjectType_Public_Static_Type_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00074788 File Offset: 0x00072988
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 71647, RefRangeEnd = 71660, XrefRangeStart = 71639, XrefRangeEnd = 71647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid GenerateUniqueGUID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_GenerateUniqueGUID_Public_Static_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000747B8 File Offset: 0x000729B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 71667, RefRangeEnd = 71673, XrefRangeStart = 71660, XrefRangeEnd = 71667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGUIDAlreadyRegistered(Guid guid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_IsGUIDAlreadyRegistered_Public_Static_Boolean_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000747F8 File Offset: 0x000729F8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 71680, RefRangeEnd = 71694, XrefRangeStart = 71673, XrefRangeEnd = 71680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGUIDValid(string guid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_IsGUIDValid_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0007483C File Offset: 0x00072A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71710, RefRangeEnd = 71711, XrefRangeStart = 71694, XrefRangeEnd = 71710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public GUIDManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00074864 File Offset: 0x00072A64
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002BE1 File Offset: 0x00000DE1
		public unsafe static List<Guid> registeredGUIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIDManager.NativeFieldInfoPtr_registeredGUIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIDManager.NativeFieldInfoPtr_registeredGUIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0007488C File Offset: 0x00072A8C
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002BF3 File Offset: 0x00000DF3
		public unsafe static Dictionary<Guid, Object> guidToObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIDManager.NativeFieldInfoPtr_guidToObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIDManager.NativeFieldInfoPtr_guidToObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_registeredGUIDs;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_guidToObject;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Public_Static_Void_IGUIDRegisterable_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterObject_Public_Static_Void_IGUIDRegisterable_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Static_T_Guid_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectType_Public_Static_Type_Guid_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueGUID_Public_Static_Guid_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_IsGUIDAlreadyRegistered_Public_Static_Boolean_Guid_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_IsGUIDValid_Public_Static_Boolean_String_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

		// Token: 0x020007A3 RID: 1955
		private sealed class MethodInfoStoreGeneric_GetObject_Public_Static_T_Guid_0<T>
		{
			// Token: 0x04007CE9 RID: 31977
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GUIDManager.NativeMethodInfoPtr_GetObject_Public_Static_T_Guid_0, Il2CppClassPointerStore<GUIDManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
