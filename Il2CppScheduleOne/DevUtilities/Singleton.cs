using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000469 RID: 1129
	public class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x060061D9 RID: 25049 RVA: 0x001BDAB0 File Offset: 0x001BBCB0
		// Note: this type is marked as 'beforefieldinit'.
		static Singleton()
		{
			Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Singleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr);
			Singleton<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "instance");
			Singleton<T>.NativeFieldInfoPtr_Destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "Destroyed");
			Singleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100675719);
			Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100675720);
			Singleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100675721);
			Singleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100675722);
			Singleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100675723);
			Singleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100675724);
			Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100675725);
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x060061DA RID: 25050 RVA: 0x001BDBD0 File Offset: 0x001BBDD0
		public unsafe static bool InstanceExists
		{
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 201239, RefRangeEnd = 201292, XrefRangeStart = 201233, XrefRangeEnd = 201239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x001BDC00 File Offset: 0x001BBE00
		// (set) Token: 0x060061DC RID: 25052 RVA: 0x001BDC30 File Offset: 0x001BBE30
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(228)]
			[CachedScanResults(RefRangeStart = 199723, RefRangeEnd = 199951, XrefRangeStart = 199723, XrefRangeEnd = 199951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x001BDCB4 File Offset: 0x001BBEB4
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Singleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x001BDCF0 File Offset: 0x001BBEF0
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 201322, RefRangeEnd = 201384, XrefRangeStart = 201292, XrefRangeEnd = 201322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Singleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x001BDD2C File Offset: 0x001BBF2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 201390, RefRangeEnd = 201396, XrefRangeStart = 201384, XrefRangeEnd = 201390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Singleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x001BDD68 File Offset: 0x001BBF68
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Singleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x0002E405 File Offset: 0x0002C605
		public Singleton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x060061E2 RID: 25058 RVA: 0x001BDDA4 File Offset: 0x001BBFA4
		// (set) Token: 0x060061E3 RID: 25059 RVA: 0x001BDDC8 File Offset: 0x001BBFC8
		public unsafe static T instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Singleton<T>.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_instance = Singleton<T>.NativeFieldInfoPtr_instance;
				T ptr2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_instance, (void*)(&ptr2));
			}
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x060061E4 RID: 25060 RVA: 0x001BDE30 File Offset: 0x001BC030
		// (set) Token: 0x060061E5 RID: 25061 RVA: 0x0002E40E File Offset: 0x0002C60E
		public unsafe bool Destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Singleton<T>.NativeFieldInfoPtr_Destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Singleton<T>.NativeFieldInfoPtr_Destroyed)) = value;
			}
		}

		// Token: 0x040042BA RID: 17082
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040042BB RID: 17083
		private static readonly IntPtr NativeFieldInfoPtr_Destroyed;

		// Token: 0x040042BC RID: 17084
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0;

		// Token: 0x040042BD RID: 17085
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040042BE RID: 17086
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0;

		// Token: 0x040042BF RID: 17087
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040042C0 RID: 17088
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040042C1 RID: 17089
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040042C2 RID: 17090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
