using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000465 RID: 1125
	public class PlayerSingleton<T> : MonoBehaviour where T : PlayerSingleton<T>
	{
		// Token: 0x0600619F RID: 24991 RVA: 0x001BCF20 File Offset: 0x001BB120
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSingleton()
		{
			Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlayerSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr);
			PlayerSingleton<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, "instance");
			PlayerSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675697);
			PlayerSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675698);
			PlayerSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675699);
			PlayerSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675700);
			PlayerSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675701);
			PlayerSingleton<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675702);
			PlayerSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675703);
			PlayerSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675704);
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x060061A0 RID: 24992 RVA: 0x001BD040 File Offset: 0x001BB240
		public unsafe static bool InstanceExists
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 200959, RefRangeEnd = 201033, XrefRangeStart = 200953, XrefRangeEnd = 200959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x060061A1 RID: 24993 RVA: 0x001BD070 File Offset: 0x001BB270
		// (set) Token: 0x060061A2 RID: 24994 RVA: 0x001BD0A0 File Offset: 0x001BB2A0
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x001BD124 File Offset: 0x001BB324
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 201033, RefRangeEnd = 201061, XrefRangeStart = 201033, XrefRangeEnd = 201033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x001BD160 File Offset: 0x001BB360
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x001BD19C File Offset: 0x001BB39C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 201097, RefRangeEnd = 201103, XrefRangeStart = 201061, XrefRangeEnd = 201097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x001BD1E8 File Offset: 0x001BB3E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 201109, RefRangeEnd = 201114, XrefRangeStart = 201103, XrefRangeEnd = 201109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x001BD224 File Offset: 0x001BB424
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSingleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x0002E27E File Offset: 0x0002C47E
		public PlayerSingleton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x060061A9 RID: 25001 RVA: 0x001BD260 File Offset: 0x001BB460
		// (set) Token: 0x060061AA RID: 25002 RVA: 0x001BD284 File Offset: 0x001BB484
		public unsafe static T instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSingleton<T>.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_instance = PlayerSingleton<T>.NativeFieldInfoPtr_instance;
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

		// Token: 0x04004296 RID: 17046
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04004297 RID: 17047
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0;

		// Token: 0x04004298 RID: 17048
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x04004299 RID: 17049
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0;

		// Token: 0x0400429A RID: 17050
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400429B RID: 17051
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400429C RID: 17052
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400429D RID: 17053
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x0400429E RID: 17054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
