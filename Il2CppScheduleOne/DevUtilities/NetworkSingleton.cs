using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200045D RID: 1117
	public class NetworkSingleton<T> : NetworkBehaviour where T : NetworkSingleton<T>
	{
		// Token: 0x060060F3 RID: 24819 RVA: 0x001BAC54 File Offset: 0x001B8E54
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkSingleton()
		{
			Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "NetworkSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr);
			NetworkSingleton<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, "instance");
			NetworkSingleton<T>.NativeFieldInfoPtr_Destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, "Destroyed");
			NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted");
			NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted");
			NetworkSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675629);
			NetworkSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675630);
			NetworkSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675631);
			NetworkSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675632);
			NetworkSingleton<T>.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675633);
			NetworkSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675634);
			NetworkSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675635);
			NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675636);
			NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675637);
			NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675638);
			NetworkSingleton<T>.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675639);
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x060060F4 RID: 24820 RVA: 0x001BADEC File Offset: 0x001B8FEC
		public unsafe static bool InstanceExists
		{
			[CallerCount(63)]
			[CachedScanResults(RefRangeStart = 199647, RefRangeEnd = 199710, XrefRangeStart = 199641, XrefRangeEnd = 199647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x060060F5 RID: 24821 RVA: 0x001BAE1C File Offset: 0x001B901C
		// (set) Token: 0x060060F6 RID: 24822 RVA: 0x001BAE4C File Offset: 0x001B904C
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199710, XrefRangeEnd = 199711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(228)]
			[CachedScanResults(RefRangeStart = 199723, RefRangeEnd = 199951, XrefRangeStart = 199711, XrefRangeEnd = 199723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x001BAED0 File Offset: 0x001B90D0
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x001BAF0C File Offset: 0x001B910C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 199952, RefRangeEnd = 199983, XrefRangeStart = 199951, XrefRangeEnd = 199952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x001BAF48 File Offset: 0x001B9148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199989, RefRangeEnd = 199990, XrefRangeStart = 199983, XrefRangeEnd = 199989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x001BAF84 File Offset: 0x001B9184
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134822, XrefRangeStart = 134800, XrefRangeEnd = 134822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkSingleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x001BAFC0 File Offset: 0x001B91C0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 199990, RefRangeEnd = 200011, XrefRangeStart = 199990, XrefRangeEnd = 199990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x001BAFFC File Offset: 0x001B91FC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 200011, RefRangeEnd = 200032, XrefRangeStart = 200011, XrefRangeEnd = 200011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x001BB038 File Offset: 0x001B9238
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x001BB074 File Offset: 0x001B9274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200058, RefRangeEnd = 200059, XrefRangeStart = 200032, XrefRangeEnd = 200058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x0002DD00 File Offset: 0x0002BF00
		public NetworkSingleton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06006100 RID: 24832 RVA: 0x001BB0B0 File Offset: 0x001B92B0
		// (set) Token: 0x06006101 RID: 24833 RVA: 0x001BB0D4 File Offset: 0x001B92D4
		public unsafe static T instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NetworkSingleton<T>.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_instance = NetworkSingleton<T>.NativeFieldInfoPtr_instance;
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

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06006102 RID: 24834 RVA: 0x001BB13C File Offset: 0x001B933C
		// (set) Token: 0x06006103 RID: 24835 RVA: 0x0002DD09 File Offset: 0x0002BF09
		public unsafe bool Destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_Destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_Destroyed)) = value;
			}
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06006104 RID: 24836 RVA: 0x001BB164 File Offset: 0x001B9364
		// (set) Token: 0x06006105 RID: 24837 RVA: 0x0002DD24 File Offset: 0x0002BF24
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06006106 RID: 24838 RVA: 0x001BB18C File Offset: 0x001B938C
		// (set) Token: 0x06006107 RID: 24839 RVA: 0x0002DD3F File Offset: 0x0002BF3F
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400422B RID: 16939
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x0400422C RID: 16940
		private static readonly IntPtr NativeFieldInfoPtr_Destroyed;

		// Token: 0x0400422D RID: 16941
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400422E RID: 16942
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400422F RID: 16943
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0;

		// Token: 0x04004230 RID: 16944
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x04004231 RID: 16945
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0;

		// Token: 0x04004232 RID: 16946
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04004233 RID: 16947
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004234 RID: 16948
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04004235 RID: 16949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004236 RID: 16950
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004237 RID: 16951
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004238 RID: 16952
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004239 RID: 16953
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
