using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000456 RID: 1110
	public static class JsonHelper : Object
	{
		// Token: 0x06006093 RID: 24723 RVA: 0x001B98A4 File Offset: 0x001B7AA4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonHelper()
		{
			Il2CppClassPointerStore<JsonHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "JsonHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr);
			JsonHelper.NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675584);
			JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675585);
			JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675586);
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x001B9910 File Offset: 0x001B7B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199277, XrefRangeEnd = 199278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FromJson<T>(string json)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x001B994C File Offset: 0x001B7B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199278, XrefRangeEnd = 199294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson<T>(Il2CppArrayBase<T> array)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x001B9988 File Offset: 0x001B7B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199294, XrefRangeEnd = 199300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson<T>(Il2CppArrayBase<T> array, bool prettyPrint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x0002DAAC File Offset: 0x0002BCAC
		public JsonHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040041ED RID: 16877
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0;

		// Token: 0x040041EE RID: 16878
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0;

		// Token: 0x040041EF RID: 16879
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x02000A11 RID: 2577
		[Serializable]
		public class Wrapper<T> : Object
		{
			// Token: 0x0600CEBA RID: 52922 RVA: 0x0031B428 File Offset: 0x00319628
			// Note: this type is marked as 'beforefieldinit'.
			static Wrapper()
			{
				Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, "Wrapper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr);
				JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr, "Items");
				JsonHelper.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr, 100675587);
			}

			// Token: 0x0600CEBB RID: 52923 RVA: 0x0031B4B8 File Offset: 0x003196B8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Wrapper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEBC RID: 52924 RVA: 0x000648B7 File Offset: 0x00062AB7
			public Wrapper(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004048 RID: 16456
			// (get) Token: 0x0600CEBD RID: 52925 RVA: 0x0031B4F4 File Offset: 0x003196F4
			// (set) Token: 0x0600CEBE RID: 52926 RVA: 0x000648C0 File Offset: 0x00062AC0
			public unsafe Il2CppArrayBase<T> Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B7D RID: 35709
			private static readonly IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x04008B7E RID: 35710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A12 RID: 2578
		private sealed class MethodInfoStoreGeneric_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0<T>
		{
			// Token: 0x04008B7F RID: 35711
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A13 RID: 2579
		private sealed class MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04008B80 RID: 35712
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A14 RID: 2580
		private sealed class MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04008B81 RID: 35713
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
